
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataEntry.Validation
    Public Class Person
        Implements IEditableObject
        Implements INotifyPropertyChanged
        Private backupEmplData As EmployeeData
        Private m_startingDate As DateTime
        Private m_firstName As String
        Private m_lastName As String
        Private m_salary As Integer
        Private m_occupation As OccupationPositions
        Private phoneNum As String

        Public Enum OccupationPositions
            Casher
            Consultant
            Security
            Supplies
            SuppliesManager
            StaffManager
            HygieneStaff
        End Enum

        Public Structure EmployeeData
            Friend startingDate As DateTime
            Friend firstName As String
            Friend lastName As String
            Friend salary As Integer
            Friend occupation As OccupationPositions
            Friend phoneNum As String
        End Structure

        '
        Public Sub New()
            Me.m_firstName = String.Empty
            Me.m_lastName = String.Empty
            Me.m_salary = 1500
            Me.phoneNum = String.Empty
        End Sub

        Public Sub New(startingDate As DateTime, fName As String, lName As String, occ As OccupationPositions, phoneNum As String, sal As Integer)
            Me.backupEmplData = New EmployeeData()
            Me.backupEmplData.startingDate = startingDate
            Me.StartingDate = startingDate
            Me.backupEmplData.salary = sal
            Me.Salary = sal
            Me.backupEmplData.firstName = fName
            Me.FirstName = fName
            Me.backupEmplData.lastName = lName
            Me.LastName = lName
            Me.backupEmplData.occupation = occ
            Me.Occupation = occ
            Me.backupEmplData.phoneNum = phoneNum
            Me.PhoneNumber = phoneNum
            Me.StartingDate = startingDate
        End Sub

        <DisplayName("First Name")> _
        Public Property FirstName() As String
            Get
                Return m_firstName
            End Get
            Set(value As String)
                m_firstName = value
                NotifyPropertyChanged("FirstName")
            End Set
        End Property

        <DisplayName("Last Name")> _
        Public Property LastName() As String
            Get
                Return m_lastName
            End Get
            Set(value As String)
                m_lastName = value
                NotifyPropertyChanged("LastName")
            End Set
        End Property

        Public Property Occupation() As OccupationPositions
            Get
                Return m_occupation
            End Get
            Set(value As OccupationPositions)
                m_occupation = value
                NotifyPropertyChanged("Occupation")
            End Set
        End Property

        <DisplayName("Starting Date")> _
        Public Property StartingDate() As DateTime
            Get
                Return m_startingDate
            End Get
            Set(value As DateTime)
                m_startingDate = value
                NotifyPropertyChanged("StartingDate")
            End Set
        End Property

        <DisplayName("Phone Number")> _
        Public Property PhoneNumber() As String
            Get
                Return phoneNum
            End Get
            Set(value As String)
                phoneNum = value
                NotifyPropertyChanged("PhoneNumber")
            End Set
        End Property

        <RadRange(1500, 1700)> _
        Public Property Salary() As Integer
            Get
                Return m_salary
            End Get
            Set(value As Integer)
                m_salary = value
                NotifyPropertyChanged("Salary")
            End Set
        End Property



        Public Sub BeginEdit() Implements IEditableObject.BeginEdit

        End Sub

        Public Sub CancelEdit() Implements IEditableObject.CancelEdit
            Salary = Me.backupEmplData.salary
            StartingDate = Me.backupEmplData.startingDate
            FirstName = Me.backupEmplData.firstName
            LastName = Me.backupEmplData.lastName
            Occupation = Me.backupEmplData.occupation
            PhoneNumber = Me.backupEmplData.phoneNum
        End Sub

        Public Sub EndEdit() Implements IEditableObject.EndEdit
            Me.backupEmplData.salary = Salary
            Me.backupEmplData.startingDate = StartingDate
            Me.backupEmplData.firstName = FirstName
            Me.backupEmplData.lastName = LastName
            Me.backupEmplData.occupation = Occupation
            Me.backupEmplData.phoneNum = PhoneNumber
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub NotifyPropertyChanged(info As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
        End Sub
    End Class
End Namespace