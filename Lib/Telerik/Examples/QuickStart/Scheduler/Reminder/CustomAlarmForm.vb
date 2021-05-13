Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Scheduler.Reminder
    Partial Public Class CustomAlarmForm
        Inherits ExamplesRadForm
        Implements IAlarmForm
        Private reminderBindableObjects As BindingList(Of RadReminderBindableObject)
        Private m_startNotification As TimeSpan
        Private m_ThemeName As String

        Public Sub New()
            InitializeComponent()
            Me.reminderBindableObjects = New BindingList(Of RadReminderBindableObject)()

            m_startNotification = New TimeSpan(0, 15, 0)

            Me.radListBox1.DisplayMember = "Subject"
            Me.radListBox1.ValueMember = "Subject"
            Me.radListBox1.DataSource = Me.reminderBindableObjects
        End Sub

        Private Sub CustomAlarmForm_FormClosing(sender As Object, e As FormClosingEventArgs)
            Me.Owner = Nothing
            If e.CloseReason <> CloseReason.ApplicationExitCall AndAlso e.CloseReason <> CloseReason.FormOwnerClosing AndAlso e.CloseReason <> CloseReason.WindowsShutDown Then
                e.Cancel = True
                Me.Hide()
            End If
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler radListBox1.SelectedIndexChanged, AddressOf radListBox1_SelectedIndexChanged
            AddHandler radButton2.Click, AddressOf radButton2_Click
            AddHandler radButton1.Click, AddressOf radButton1_Click
            AddHandler radButton3.Click, AddressOf radButton3_Click
            AddHandler radButton4.Click, AddressOf radButton4_Click
            AddHandler FormClosing, AddressOf CustomAlarmForm_FormClosing
        End Sub

#Region "IAlarmForm Members"
        Public Event ItemOpened As EventHandler(Of RadOpenItemArgs) Implements IAlarmForm.ItemOpened
        ''' <summary>
        ''' Gets the remind objects count.
        ''' </summary>
        ''' <value>The reminder bindable objects count.</value>
        Public Overridable ReadOnly Property RemindObjectsCount() As Integer Implements IAlarmForm.RemindObjectsCount
            Get
                Return Me.reminderBindableObjects.Count
            End Get
        End Property

        ''' <summary>
        ''' Determines whether [contains reminder bindable object] [the specified reminder bindable object].
        ''' </summary>
        ''' <param name="reminderBindableObject">The remind bindable object.</param>
        ''' <returns>
        ''' 	<c>true</c> if [contains reminder bindable object] [the specified reminder bindable object]; otherwise, <c>false</c>.
        ''' </returns>
        Public Overridable Function ContainsRemindObject(reminderBindableObject As RadReminderBindableObject) As Boolean Implements IAlarmForm.ContainsRemindObject
            Return Me.reminderBindableObjects.Contains(reminderBindableObject)
        End Function

        ''' <summary>
        ''' Adds the reminder bindable object.
        ''' </summary>
        ''' <param name="reminderBindableObject">The reminder bindable object.</param>
        Public Overridable Sub AddRemindObject(reminderBindableObject As RadReminderBindableObject) Implements IAlarmForm.AddRemindObject
            Me.reminderBindableObjects.Insert(0, reminderBindableObject)
        End Sub

        ''' <summary>
        ''' Removes the reminder bindable object.
        ''' </summary>
        ''' <param name="reminderBindableObject">The reminder bindable object.</param>
        ''' <returns></returns>
        Public Overridable Function RemoveRemindObject(reminderBindableObject As RadReminderBindableObject) As Boolean Implements IAlarmForm.RemoveRemindObject
            Dim res As Boolean = Me.reminderBindableObjects.Remove(reminderBindableObject)

            If Me.reminderBindableObjects.Count < 1 Then
                Me.Hide()
            End If

            Return res
        End Function

        ''' <summary>
        ''' Shows the form.
        ''' </summary>
        Public Overridable Sub ShowForm() Implements IAlarmForm.ShowForm
            If Not Me.Visible Then
                Me.Show()
            End If
        End Sub

        ''' <summary>
        ''' Shows the form.
        ''' </summary>
        ''' <param name="owner">The owner.</param>
        Public Overridable Sub ShowForm(owner As IWin32Window) Implements IAlarmForm.ShowForm
            If Not Me.Visible Then
                Me.Show(owner)
            End If
        End Sub

        ''' <summary>
        ''' In this override we reset the RootElement's BackColor property
        ''' since the DocumentDesigner class sets the BackColor of the
        ''' Form to Control when initializing and thus overrides the theme.
        ''' </summary>
        ''' <param name="e"></param>
        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.UpdateDialogLocalization()
        End Sub

        ''' <summary>
        ''' Updates the dialog localization.
        ''' </summary>
        Public Sub UpdateDialogLocalization()
            'Apply the current localization provider.
        End Sub

        ''' <summary>
        ''' Gets or sets the start notification.
        ''' </summary>
        ''' <value>The start notification.</value>
        Public Property StartNotification() As TimeSpan Implements IAlarmForm.StartNotification
            Get
                Return Me.m_startNotification
            End Get
            Set(value As TimeSpan)
                Me.m_startNotification = value
            End Set
        End Property

        Public Overloads Property ThemeNameFromInterface() As String Implements IAlarmForm.ThemeName
            Get
                Return m_ThemeName
            End Get
            Set(value As String)
                m_ThemeName = value
            End Set
        End Property

        ''' <summary>
        ''' Clears the remind objects.
        ''' </summary>
        Public Sub ClearRemindObjects() Implements IAlarmForm.ClearRemindObjects
            Me.reminderBindableObjects.Clear()
        End Sub

        ''' <summary>
        ''' Hides the form.
        ''' </summary>
        Public Sub HideForm() Implements IAlarmForm.HideForm
            Me.Hide()
        End Sub
#End Region

        Private Sub radButton1_Click(sender As Object, e As EventArgs)
            For Each item As RadListDataItem In Me.radListBox1.SelectedItems
                Dim reminderBindableObject As RadReminderBindableObject = TryCast(item.DataBoundItem, RadReminderBindableObject)
                Me.OnItemOpened(reminderBindableObject.RemindObject)
            Next
        End Sub

        Private Sub OnItemOpened(remidableObject As IRemindObject)
            RaiseEvent ItemOpened(Me, New RadOpenItemArgs(remidableObject))
        End Sub

        Private Sub radButton2_Click(sender As Object, e As EventArgs)
            Dim selectedIndexes As List(Of Integer) = Me.GetSelectedIndexes()
            For i As Integer = selectedIndexes.Count - 1 To 0 Step -1
                Dim selectedIndex As Integer = selectedIndexes(i)
                Dim item As RadListDataItem = Me.radListBox1.Items(selectedIndex)
                Dim reminderBindableObject As RadReminderBindableObject = TryCast(item.DataBoundItem, RadReminderBindableObject)
                Dim snooze As TimeSpan = DateTime.Now.Subtract(reminderBindableObject.StartDateTime)
                reminderBindableObject.Snoozed = Me.m_startNotification + snooze + (New TimeSpan(0, 1, 0))
                Me.RemoveRemindObject(reminderBindableObject)
            Next

            EnableButtons()
        End Sub

        Private Function GetSelectedIndexes() As List(Of Integer)
            Dim resList As New List(Of Integer)()
            For Each item As RadListDataItem In Me.radListBox1.SelectedItems
                resList.Add(Me.radListBox1.Items.IndexOf(item))
            Next
            resList.Sort()
            Return resList
        End Function

        Private Sub radButton3_Click(sender As Object, e As EventArgs)
            Dim selectedIndexes As List(Of Integer) = Me.GetSelectedIndexes()
            For i As Integer = selectedIndexes.Count - 1 To 0 Step -1
                Dim selectedIndex As Integer = selectedIndexes(i)
                Dim item As RadListDataItem = Me.radListBox1.Items(selectedIndex)
                DismissItem(item)
            Next

            EnableButtons()
        End Sub

        Private Sub radButton4_Click(sender As Object, e As EventArgs)
            For i As Integer = Me.radListBox1.Items.Count - 1 To 0 Step -1
                Dim item As RadListDataItem = Me.radListBox1.Items(i)
                DismissItem(item)
            Next

            EnableButtons()
        End Sub

        Private Sub DismissItem(item As RadListDataItem)
            Dim reminderBindableObject As RadReminderBindableObject = TryCast(item.DataBoundItem, RadReminderBindableObject)
            reminderBindableObject.Dismissed = True
            Me.RemoveRemindObject(reminderBindableObject)
        End Sub

        Private Sub EnableButtons()
            Dim enableButtons As Boolean = (Me.radListBox1.SelectedItems.Count > 0)
            Me.radButton3.Enabled = enableButtons
            Me.radButton2.Enabled = enableButtons
            Me.radButton1.Enabled = enableButtons

            Me.radButton4.Enabled = (Me.radListBox1.Items.Count > 0)
        End Sub

        Private Sub radListBox1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            EnableButtons()
        End Sub

        Protected Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            ThemeResolutionService.ApplyThemeToControlTree(Me, Me.ThemeName)
        End Sub
    End Class
End Namespace