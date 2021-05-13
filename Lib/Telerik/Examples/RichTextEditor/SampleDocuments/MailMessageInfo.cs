
namespace RichTextEditor.SampleData
{
    public class MailMessageInfo
    {
        #region Properties

        public string SenderFirstName { get; set; }
        public string SenderLastName { get; set; }
        public string SenderJobTitle { get; set; }
        public string SenderAdress { get; set; }

        public string RecipientFirstName { get; set; }
        public string RecipientLastName { get; set; }
        public string RecipientPhoto { get; set; }

        public string SupportOfficerFirstName { get; set; }
        public string SupportOfficerLastName { get; set; }
        public string FullRecipientName
        {
            get { return this.RecipientFirstName + " " + this.RecipientLastName; }
        }

        #endregion
    }
}
