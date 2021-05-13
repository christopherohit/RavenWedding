
Imports System.Collections.Generic
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.SampleData
    Public Class ExamplesDataContext
        Private m_employees As List(Of Employee)
        Private m_users As PermissionInfoCollection
        Private m_currentUsers As List(Of UserInfo)
        Private m_mailMessageInfos As List(Of MailMessageInfo)

        Public ReadOnly Property Employees() As List(Of Employee)
            Get
                If Me.m_employees Is Nothing Then
                    Me.m_employees = New List(Of Employee)() From { _
                        New Employee() With { _
                             .FirstName = "Andrew", _
                             .LastName = "Fuller", _
                             .JobTitle = "Director - Finance" _
                        }, _
                        New Employee() With { _
                             .FirstName = "Nancy", _
                             .LastName = "Davolio", _
                             .JobTitle = "Director - Human Resources" _
                        }, _
                        New Employee() With { _
                             .FirstName = "Robert", _
                             .LastName = "King", _
                             .JobTitle = "Engineering Design Manager" _
                        }, _
                        New Employee() With { _
                             .FirstName = "Margaret", _
                             .LastName = "Peacock", _
                             .JobTitle = "Finance & Investments Officer" _
                        } _
                    }
                End If

                Return m_employees
            End Get
        End Property

        Public ReadOnly Property Users() As PermissionInfoCollection
            Get
                If Me.m_users Is Nothing Then
                    Me.m_users = New PermissionInfoCollection() From { _
                        PermissionInfo.CreateEveryonePermissionInfo(), _
                        New PermissionInfo("jmiller", PermissionType.Individual, "James Miller"), _
                        New PermissionInfo("jsmith", PermissionType.Individual, "John Smith"), _
                        New PermissionInfo("rbrown", PermissionType.Individual, "Robert Brown"), _
                        New PermissionInfo("Administrators", PermissionType.Group, "Administrators") _
                    }
                End If

                Return m_users
            End Get
        End Property

        Public ReadOnly Property CurrentUsers() As List(Of UserInfo)
            Get
                If Me.m_currentUsers Is Nothing Then
                    Me.m_currentUsers = New List(Of UserInfo)() From { _
                        New UserInfo("Users", "James Miller", "jmiller", "jmiller@example.com"), _
                        New UserInfo("Administrators", "John Smith", "jsmith", "jsmith@example.com"), _
                        New UserInfo("Administrators", "Robert Brown", "rbrown", "rbrown@example.com") _
                    }
                End If

                Return Me.m_currentUsers
            End Get
        End Property

        Public ReadOnly Property MailMessageInfos() As List(Of MailMessageInfo)
            Get
                If Me.m_mailMessageInfos Is Nothing Then
                    Me.m_mailMessageInfos = New List(Of MailMessageInfo)() From { _
                        New MailMessageInfo() With { _
                             .SenderFirstName = "Andrew", _
                             .SenderLastName = "Fuller", _
                             .SenderJobTitle = "Director - Finance", _
                             .SenderAdress = "908 W. Capital Way", _
                             .RecipientFirstName = "Maria", _
                             .RecipientLastName = "Anders", _
                             .RecipientPhoto = "female1.png", _
                             .SupportOfficerFirstName = "Matti", _
                             .SupportOfficerLastName = "Karttunen" _
                        }, _
                        New MailMessageInfo() With { _
                            .SenderFirstName = "Nancy", _
                            .SenderLastName = "Davolio", _
                            .SenderJobTitle = "Sales Representative", _
                            .SenderAdress = "507 - 20th Ave. E.", _
                            .RecipientFirstName = "Antonio", _
                            .RecipientLastName = "Taquería", _
                            .RecipientPhoto = "male1.png", _
                            .SupportOfficerFirstName = "Paula", _
                            .SupportOfficerLastName = "Parente" _
                        }, _
                        New MailMessageInfo() With { _
                            .SenderFirstName = "Janet", _
                            .SenderLastName = "Leverling", _
                            .SenderJobTitle = "Sales Representative", _
                            .SenderAdress = "722 Moss Bay Blvd.", _
                            .RecipientFirstName = "Thomas", _
                            .RecipientLastName = "Hardy", _
                            .RecipientPhoto = "male2.png", _
                            .SupportOfficerFirstName = "Paula", _
                            .SupportOfficerLastName = "Parente" _
                        }, _
                        New MailMessageInfo() With { _
                             .SenderFirstName = "Margaret", _
                             .SenderLastName = "Peacock", _
                             .SenderJobTitle = "Sales Representative", _
                             .SenderAdress = "4110 Old Redmond Rd.", _
                             .RecipientFirstName = "Martín", _
                             .RecipientLastName = "Sommer", _
                             .RecipientPhoto = "male3.png", _
                             .SupportOfficerFirstName = "Palle", _
                             .SupportOfficerLastName = "Ibsen" _
                        }, _
                        New MailMessageInfo() With { _
                             .SenderFirstName = "Robert", _
                             .SenderLastName = "King", _
                             .SenderJobTitle = "Sales Representative", _
                             .SenderAdress = "Edgeham Hollow", _
                             .RecipientFirstName = "Anabela", _
                             .RecipientLastName = "Domingues", _
                             .RecipientPhoto = "female2.png", _
                             .SupportOfficerFirstName = "Carlos", _
                             .SupportOfficerLastName = "Hernández" _
                        }, _
                        New MailMessageInfo() With { _
                             .SenderFirstName = "Horst", _
                             .SenderLastName = "Kloss", _
                             .SenderJobTitle = "Inside Sales Coordinator", _
                             .SenderAdress = "4726 - 11th Ave. N.E.", _
                             .RecipientFirstName = "Anne", _
                             .RecipientLastName = "Dodsworth", _
                             .RecipientPhoto = "female3.png", _
                             .SupportOfficerFirstName = "Sergio", _
                             .SupportOfficerLastName = "Gutiérrez" _
                        } _
                    }
                End If

                Return m_mailMessageInfos
            End Get
        End Property
    End Class
End Namespace