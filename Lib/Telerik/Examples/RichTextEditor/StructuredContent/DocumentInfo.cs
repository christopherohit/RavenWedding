using System;

namespace RichTextEditor.StructuredContent
{
    public class DocumentInfo
    {
        #region Properties

        public string Name { get; set; }
        public string Path { get; set; }

        #endregion

        #region Constructors

        public DocumentInfo(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }
}
