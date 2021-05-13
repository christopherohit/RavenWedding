Imports System

Namespace RichTextEditor.SampleData
    Public Class MailMessageInfo
#Region "Properties"

        Public Property SenderFirstName() As String
            Get
                Return m_SenderFirstName
            End Get
            Set(value As String)
                m_SenderFirstName = value
            End Set
        End Property
        Private m_SenderFirstName As String
        Public Property SenderLastName() As String
            Get
                Return m_SenderLastName
            End Get
            Set(value As String)
                m_SenderLastName = value
            End Set
        End Property
        Private m_SenderLastName As String
        Public Property SenderJobTitle() As String
            Get
                Return m_SenderJobTitle
            End Get
            Set(value As String)
                m_SenderJobTitle = value
            End Set
        End Property
        Private m_SenderJobTitle As String
        Public Property SenderAdress() As String
            Get
                Return m_SenderAdress
            End Get
            Set(value As String)
                m_SenderAdress = value
            End Set
        End Property
        Private m_SenderAdress As String

        Public Property RecipientFirstName() As String
            Get
                Return m_RecipientFirstName
            End Get
            Set(value As String)
                m_RecipientFirstName = value
            End Set
        End Property
        Private m_RecipientFirstName As String
        Public Property RecipientLastName() As String
            Get
                Return m_RecipientLastName
            End Get
            Set(value As String)
                m_RecipientLastName = value
            End Set
        End Property
        Private m_RecipientLastName As String
        Public Property RecipientPhoto() As String
            Get
                Return m_RecipientPhoto
            End Get
            Set(value As String)
                m_RecipientPhoto = value
            End Set
        End Property
        Private m_RecipientPhoto As String

        Public Property SupportOfficerFirstName() As String
            Get
                Return m_SupportOfficerFirstName
            End Get
            Set(value As String)
                m_SupportOfficerFirstName = value
            End Set
        End Property
        Private m_SupportOfficerFirstName As String
        Public Property SupportOfficerLastName() As String
            Get
                Return m_SupportOfficerLastName
            End Get
            Set(value As String)
                m_SupportOfficerLastName = value
            End Set
        End Property
        Private m_SupportOfficerLastName As String
        Public ReadOnly Property FullRecipientName() As String
            Get
                Return Convert.ToString(Me.RecipientFirstName & Convert.ToString(" ")) & Me.RecipientLastName
            End Get
        End Property

#End Region
    End Class
End Namespace