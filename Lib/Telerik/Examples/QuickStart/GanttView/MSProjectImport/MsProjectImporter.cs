using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;

namespace Telerik.Examples.WinControls.GanttView.MSProjectImport
{
    public class MsProjectImporter
    {
        private Dictionary<int, List<DataRow>> tasksByLevel;
        private DataSet dataSet;

        public DataSet GetData(TextReader reader)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            this.InitializeDataStructures();
            this.ExtractTasks(doc);
            ImporterNode root = this.BuildTasksHierarchy();
            this.SaveTasksDataTable(root);
            this.SaveLinksDataTable(doc);

            return this.dataSet;
        }

        private void InitializeDataStructures()
        {
            this.tasksByLevel = new Dictionary<int, List<DataRow>>();
            DataTable tasks = new DataTable("Tasks");
            tasks.Columns.Add("Id", typeof(int));
            tasks.Columns.Add("ParentId", typeof(int));
            tasks.Columns.Add("Title", typeof(string));
            tasks.Columns.Add("Start", typeof(DateTime));
            tasks.Columns.Add("End", typeof(DateTime));
            tasks.Columns.Add("Progress", typeof(decimal));
            tasks.Columns.Add("Outline", typeof(string));

            DataTable links = new DataTable("Links");
            links.Columns.Add("StartId", typeof(int));
            links.Columns.Add("EndId", typeof(int));
            links.Columns.Add("LinkType", typeof(int));

            this.dataSet = new DataSet();
            this.dataSet.Tables.Add(tasks);
            this.dataSet.Tables.Add(links);
        }

        private ImporterNode BuildTasksHierarchy()
        {
            ImporterNode root = null;

            foreach (int key in this.tasksByLevel.Keys)
            {
                if (key == 0)
                {
                    root = new ImporterNode();
                    root.Row = this.tasksByLevel[key][0];

                    continue;
                }

                foreach (DataRow row in this.tasksByLevel[key])
                {
                    List<string> outlineIndexes = new List<string>(row["Outline"].ToString().Split('.'));

                    ImporterNode parent = root;

                    while (outlineIndexes.Count > 1)
                    {
                        parent = parent.Children[int.Parse(outlineIndexes[0]) - 1];
                        outlineIndexes.RemoveAt(0);
                    }

                    ImporterNode newNode = new ImporterNode();
                    newNode.Row = row;
                    newNode.Row["ParentId"] = parent.Row["Id"];
                    parent.Children.Add(newNode);
                }
            }

            return root;
        }

        private void ExtractTasks(XmlDocument doc)
        {
            foreach (XmlNode node in doc.DocumentElement["Tasks"].ChildNodes)
            {
                if (node["OutlineNumber"] == null)
                {
                    continue;
                }

                DataRow row = this.dataSet.Tables["Tasks"].NewRow();
                int outlineLevel = int.Parse(node["OutlineLevel"].InnerText);
                int id = int.Parse(node["UID"].InnerText);
                row["Id"] = id;
                row["ParentId"] = 0;
                row["Title"] = node["Name"].InnerText;
                row["Start"] = DateTime.Parse(node["Start"].InnerText);
                row["End"] = DateTime.Parse(node["Finish"].InnerText);
                row["Progress"] = decimal.Parse(node["PercentComplete"].InnerText);
                row["Outline"] = node["OutlineNumber"].InnerText;

                if (this.tasksByLevel.ContainsKey(outlineLevel))
                {
                    this.tasksByLevel[outlineLevel].Add(row);
                }
                else
                {
                    this.tasksByLevel.Add(outlineLevel, new List<DataRow>() { row });
                }
            }
        }

        private void SaveTasksDataTable(ImporterNode root)
        {
            Queue<ImporterNode> queue = new Queue<ImporterNode>();

            foreach (ImporterNode node in root.Children)
            {
                queue.Enqueue(node);
            }

            while (queue.Count > 0)
            {
                ImporterNode node = queue.Dequeue();

                foreach (ImporterNode item in node.Children)
                {
                    queue.Enqueue(item);
                }

                this.dataSet.Tables["Tasks"].Rows.Add(node.Row);
            }

            dataSet.Tables["Tasks"].Columns.Remove("Outline");
        }

        private void SaveLinksDataTable(XmlDocument doc)
        {
            foreach (XmlNode node in doc.DocumentElement["Tasks"].ChildNodes)
            {
                XmlNode predecessor = node["PredecessorLink"];

                if (predecessor != null)
                {
                    int id = int.Parse(node["UID"].InnerText);
                    int startId = int.Parse(predecessor["PredecessorUID"].InnerText);
                    int linkType = int.Parse(predecessor["Type"].InnerText);

                    this.dataSet.Tables["Links"].Rows.Add(startId, id, linkType);
                }
            }
        }
    }

    public class ImporterNode
    {
        private DataRow row;
        private List<ImporterNode> children;

        public ImporterNode()
        {
            this.children = new List<ImporterNode>();
        }

        public DataRow Row
        {
            get { return row; }
            set { row = value; }
        }

        public List<ImporterNode> Children
        {
            get { return children; }
        }
    }
}
