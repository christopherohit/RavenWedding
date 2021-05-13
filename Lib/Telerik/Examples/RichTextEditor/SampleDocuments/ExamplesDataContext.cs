using System.Collections.Generic;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.SampleData
{
    public class ExamplesDataContext
    {
        private List<Employee> employees;
        private PermissionInfoCollection users;
        private List<UserInfo> currentUsers;
        private List<MailMessageInfo> mailMessageInfos;

        public List<Employee> Employees
        {
            get
            {
                if (this.employees == null)
                {
                    this.employees = new List<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Andrew",
                            LastName = "Fuller", 
                            JobTitle = "Director - Finance",
                        }, 
                        new Employee()
                        {
                            FirstName = "Nancy",
                            LastName = "Davolio", 
                            JobTitle = "Director - Human Resources",
                        },
                        new Employee()
                        {
                            FirstName = "Robert",
                            LastName = "King", 
                            JobTitle = "Engineering Design Manager",
                        },
                        new Employee()
                        {
                            FirstName = "Margaret",
                            LastName = "Peacock", 
                            JobTitle = "Finance & Investments Officer",
                        }
                    };
                }

                return employees;
            }
        }

        public PermissionInfoCollection Users
        {
            get
            {
                if (this.users == null)
                {
                    this.users = new PermissionInfoCollection() 
                    {
                        PermissionInfo.CreateEveryonePermissionInfo(),
                        new PermissionInfo("jmiller", PermissionType.Individual, "James Miller"),
                        new PermissionInfo("jsmith", PermissionType.Individual, "John Smith"),
                        new PermissionInfo("rbrown", PermissionType.Individual, "Robert Brown"),
                        new PermissionInfo("Administrators", PermissionType.Group, "Administrators"),
                    };
                }

                return users;
            }
        }

        public List<UserInfo> CurrentUsers
        {
            get
            {
                if (this.currentUsers == null)
                {
                    this.currentUsers = new List<UserInfo>() 
                    {
                        new UserInfo("Users", "James Miller", "jmiller", "jmiller@example.com"),
                        new UserInfo("Administrators", "John Smith", "jsmith", "jsmith@example.com"),
                        new UserInfo("Administrators", "Robert Brown", "rbrown", "rbrown@example.com"),
                    };
                }

                return this.currentUsers;
            }
        }

        public List<MailMessageInfo> MailMessageInfos
        {
            get
            {
                if (this.mailMessageInfos == null)
                {
                    this.mailMessageInfos = new List<MailMessageInfo>()
                    {
                        new MailMessageInfo()
                        {
                            SenderFirstName = "Andrew",
                            SenderLastName = "Fuller", 
                            SenderJobTitle = "Director - Finance",
                            SenderAdress = "908 W. Capital Way",
                            RecipientFirstName = "Maria",
                            RecipientLastName = "Anders",
                            RecipientPhoto = "female1.png",
                            SupportOfficerFirstName = "Matti",
                            SupportOfficerLastName = "Karttunen"
                        }, 
                        new MailMessageInfo()
                        {
                            SenderFirstName = "Nancy",
                            SenderLastName = "Davolio", 
                            SenderJobTitle = "Sales Representative",
                            SenderAdress = "507 - 20th Ave. E.",
                            RecipientFirstName = "Antonio",
                            RecipientLastName = "Taquería",
                            RecipientPhoto = "male1.png",
                            SupportOfficerFirstName = "Paula",
                            SupportOfficerLastName = "Parente"
                        }, 
                        new MailMessageInfo()
                        {
                            SenderFirstName = "Janet",
                            SenderLastName = "Leverling", 
                            SenderJobTitle = "Sales Representative",
                            SenderAdress = "722 Moss Bay Blvd.",
                            RecipientFirstName = "Thomas",
                            RecipientLastName = "Hardy",
                            RecipientPhoto = "male2.png",
                            SupportOfficerFirstName = "Paula",
                            SupportOfficerLastName = "Parente"
                        }, 
                        new MailMessageInfo()
                        {
                            SenderFirstName = "Margaret",
                            SenderLastName = "Peacock", 
                            SenderJobTitle = "Sales Representative",
                            SenderAdress = "4110 Old Redmond Rd.",
                            RecipientFirstName = "Martín",
                            RecipientLastName = "Sommer",
                            RecipientPhoto = "male3.png",
                            SupportOfficerFirstName = "Palle",
                            SupportOfficerLastName = "Ibsen"
                        }, 
                        new MailMessageInfo()
                        {
                            SenderFirstName = "Robert",
                            SenderLastName = "King", 
                            SenderJobTitle = "Sales Representative",
                            SenderAdress = "Edgeham Hollow",
                            RecipientFirstName = "Anabela",
                            RecipientLastName = "Domingues",
                            RecipientPhoto = "female2.png",
                            SupportOfficerFirstName = "Carlos",
                            SupportOfficerLastName = "Hernández"
                        }, 
                        new MailMessageInfo()
                        {
                            SenderFirstName = "Horst",
                            SenderLastName = "Kloss", 
                            SenderJobTitle = "Inside Sales Coordinator",
                            SenderAdress = "4726 - 11th Ave. N.E.",
                            RecipientFirstName = "Anne",
                            RecipientLastName = "Dodsworth",
                            RecipientPhoto = "female3.png",
                            SupportOfficerFirstName = "Sergio",
                            SupportOfficerLastName = "Gutiérrez"
                        }
                    };
                }

                return mailMessageInfos;
            }
        }
    }
}
