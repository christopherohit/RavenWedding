using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagramFirstLook
{
    public partial class Form1 
    {
        public class Shapes : INotifyPropertyChanged
        {
            private string id;
            private string text;
            private string type;
            private double x;
            private double y;
            private double width;
            private double height;


            public string Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                    if (this.id != value)
                    {
                        this.id = value;
                        OnPropertyChanged("Id");
                    }
                }
            }

            public string Text
            {
                get
                {
                    return this.text;
                }
                set
                {
                    this.text = value;
                    if (this.text != value)
                    {
                        this.text = value;
                        OnPropertyChanged("Text");
                    }
                }
            }

            public string Type
            {
                get
                {
                    return this.type;
                }
                set
                {
                    if (this.type != value)
                    {
                        this.type = value;
                        OnPropertyChanged("Type");
                    }
                }
            }

            public double X
            {
                get
                {
                    return this.x;
                }
                set
                {
                    if (this.x != value)
                    {
                        this.x = value;
                        OnPropertyChanged("X");
                    }
                }
            }

            public double Y
            {
                get
                {
                    return this.y;
                }
                set
                {
                    this.y = value;
                    if (this.y != value)
                    {
                        this.y = value;
                        OnPropertyChanged("Y");
                    }
                }
            }

            public double Height
            {
                get
                {
                    return this.height;
                }
                set
                {
                    if (this.height != value)
                    {
                        this.height = value;
                        OnPropertyChanged("Height");
                    }
                   
                }
            }

            public double Width
            {
                get
                {
                    return this.width;
                }
                set
                {
                    if (this.width != value)
                    {
                        this.width = value;
                        OnPropertyChanged("Width");
                    }
                }
            }

            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        public class Connections : INotifyPropertyChanged
        {
            private string sourceShapeId;
            private string sourceConnector;
            private string targetShapeId;
            private string targetConnector;
            private string startCapField;
            private string endCapField;

            public string EndCapField
            {
                get
                {
                    return this.endCapField;
                }
                set
                {
                    this.endCapField = value;
                    if (this.endCapField != value)
                    {
                        this.endCapField = value;
                        OnPropertyChanged("EndCapField");
                    }
                }
            }

            public string StartCapField
            {
                get
                {
                    return this.startCapField;
                }
                set
                {
                    this.startCapField = value;
                    if (this.startCapField != value)
                    {
                        this.startCapField = value;
                        OnPropertyChanged("StartCapField");
                    }
                }
            }

            public string TargetConnector
            {
                get
                {
                    return this.targetConnector;
                }
                set
                {
                    this.targetConnector = value;
                    if (this.targetConnector != value)
                    {
                        this.targetConnector = value;
                        OnPropertyChanged("TargetConnector");
                    }
                }
            }

            public string TargetShapeId
            {
                get
                {
                    return this.targetShapeId;
                }
                set
                {
                    this.targetShapeId = value;
                    if (this.targetShapeId != value)
                    {
                        this.targetShapeId = value;
                        OnPropertyChanged("TargetShapeId");
                    }
                }
            }

            public string SourceConnector
            {
                get
                {
                    return this.sourceConnector;
                }
                set
                {
                    this.sourceConnector = value;
                    if (this.sourceConnector != value)
                    {
                        this.sourceConnector = value;
                        OnPropertyChanged("SourceConnector");
                    }
                }
            }

            public string SourceShapeId
            {
                get
                {
                    return this.sourceShapeId;
                }
                set
                {
                    this.sourceShapeId = value;
                    if (this.sourceShapeId != value)
                    {
                        this.sourceShapeId = value;
                        OnPropertyChanged("SourceShapeId");
                    }
                }
            }

            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        public class Main
        {   
            public BindingList<Shapes> Shapes
            {
                get { return GetShapes(); }
            }

             public BindingList<Connections>  Connections
            {
                get { return GetConnections(); }
            }


            private BindingList<Shapes> GetShapes()
            {
                return new BindingList<Shapes>() {
                        new Shapes() {Id="Shape1", Text="Shape 1", Type="circle",    X=100, Y=300, Width=50,  Height=50},
                        new Shapes() {Id="Shape2", Text="Shape 2", Type="rectangle", X=200, Y=100, Width=100, Height=100},
                        new Shapes() {Id="Shape3", Text="Shape 3", Type="circle",    X=300, Y=300, Width=50,  Height=50},
                        new Shapes() {Id="Shape4", Text="Shape 4", Type="rectangle", X=400, Y=100, Width=100, Height=100},
                        new Shapes() {Id="Shape5", Text="Shape 5", Type="circle",    X=500, Y=300, Width=50,  Height=50}
                        };
            }

            private BindingList<Connections> GetConnections()
            {
                return new BindingList<Connections> () {
                        new Connections(){SourceShapeId="Shape2", SourceConnector="Auto", TargetShapeId="Shape1", TargetConnector="Auto", StartCapField="Arrow5Filled", EndCapField="Arrow1"},
                        new Connections(){SourceShapeId="Shape2", SourceConnector="Auto", TargetShapeId="Shape3", TargetConnector="Auto", StartCapField="Arrow4Filled", EndCapField="Arrow1Filled"},
                        new Connections(){SourceShapeId="Shape4", SourceConnector="Auto", TargetShapeId="Shape5", TargetConnector="Auto", StartCapField="Arrow2Filled", EndCapField="Arrow2"}
                        };
            }
        }

        private void SetupDataBindindngs()
        {   
            DataTable shapesTable = new DataTable("Shapes");
            DataTable connectionsTable = new DataTable("Connections");
            shapesTable.Columns.Clear();
            shapesTable.Columns.Add("Id");
            shapesTable.Columns.Add("Text");
            shapesTable.Columns.Add("Type");
            shapesTable.Columns.Add("X");
            shapesTable.Columns.Add("Y");
            shapesTable.Columns.Add("Width");
            shapesTable.Columns.Add("Height");
            shapesTable.Rows.Add("Shape1", "Shape 1", "circle", 100, 300, 50, 50);
            shapesTable.Rows.Add("Shape2", "Shape 2", "rectangle", 200, 100, 100, 100);
            shapesTable.Rows.Add("Shape3", "Shape 3", "circle", 300, 300, 50, 50);
            shapesTable.Rows.Add("Shape4", "Shape 4", "rectangle", 400, 100, 100, 100);
            shapesTable.Rows.Add("Shape5", "Shape 5", "circle", 500, 300, 50, 50);

            connectionsTable.Columns.Clear();
            connectionsTable.Columns.Add("SourceShapeId");
            connectionsTable.Columns.Add("SourceConnector");
            connectionsTable.Columns.Add("TargetShapeId");
            connectionsTable.Columns.Add("TargetConnector");
            connectionsTable.Columns.Add("StartCapField");
            connectionsTable.Columns.Add("EndCapField");
            connectionsTable.Rows.Add("Shape2", "Auto", "Shape1", "Auto", "Arrow5Filled", "Arrow1");
            connectionsTable.Rows.Add("Shape2", "Auto", "Shape3", "Auto", "Arrow4Filled", "Arrow1Filled");
            connectionsTable.Rows.Add("Shape4", "Auto", "Shape5", "Auto", "Arrow2Filled", "Arrow2");

            DataSet ds = new DataSet();
            ds.Tables.Add(shapesTable);
            ds.Tables.Add(connectionsTable);

            BindingSource bindingSource1 = new BindingSource();

            bindingSource1.DataSource =  ds;


            this.radDiagram1.DiagramElement.DataLayer.DataSource = new Main();

            this.radDiagram1.DiagramElement.DataLayer.ConnectionDataMember = "Connections";
            this.radDiagram1.DiagramElement.DataLayer.ShapeDataMember = "Shapes";
 
            this.radDiagram1.DiagramElement.DataLayer.ConnectionTargetCapTypeMember = "endCapField";
            this.radDiagram1.DiagramElement.DataLayer.ConnectionSourceCapTypeMember   = "startCapField";
            this.radDiagram1.DiagramElement.DataLayer.ConnectionSourceShapeIdMember = "sourceShapeId";
            this.radDiagram1.DiagramElement.DataLayer.ConnectionTargetShapeIdMember = "targetShapeId";
            this.radDiagram1.DiagramElement.DataLayer.ConnectionSourceConnectorMember = "sourceConnector";
            this.radDiagram1.DiagramElement.DataLayer.ConnectionTargetConnectorMember = "targetConnector";

            this.radDiagram1.DiagramElement.DataLayer.ShapeXMember = "x";
            this.radDiagram1.DiagramElement.DataLayer.ShapeYMember = "y";
            this.radDiagram1.DiagramElement.DataLayer.ShapeWidthMember = "width";
            this.radDiagram1.DiagramElement.DataLayer.ShapeHeightMember = "height";
            this.radDiagram1.DiagramElement.DataLayer.ShapeTypeMember = "type";
            this.radDiagram1.DiagramElement.DataLayer.ShapeIdMember = "id";
            this.radDiagram1.DiagramElement.DataLayer.ShapeTextMember = "text";
        }

    }
}
