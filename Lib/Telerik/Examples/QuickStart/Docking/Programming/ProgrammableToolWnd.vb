Imports System.Text
Imports Telerik.WinControls.UI.Docking

Namespace Telerik.Examples.WinControls.Docking.Programming
	Friend Class ProgrammableToolWnd
		Inherits DockWindow
		Private groupBox As GroupBox
		Private WithEvents buttonUnpin As Button
		Private WithEvents buttonPin As Button
		Private WithEvents buttonFloat As Button
		Private WithEvents buttonClose As Button
		Private WithEvents buttonDock As Button

		Private actionButtons As New Dictionary(Of String, Button)()



		Public Sub New()
			InitializeComponent()
			'this.Activated += new EventHandler(ProgrammableToolWnd_Activated);

			actionButtons.Add("Unpin", buttonUnpin)
			actionButtons.Add("Pin", buttonPin)
			actionButtons.Add("Float", buttonFloat)
			actionButtons.Add("Close", buttonClose)
			actionButtons.Add("Dock", buttonDock)
		End Sub

		Private Sub ProgrammableToolWnd_Activated(ByVal sender As Object, ByVal e As EventArgs)
			'if (this.DockingSite != null && this.DockingSite.DockingSiteType == DockingSiteType.FloatingContainerSite)
			'{
			'    this.buttonFloat.Enabled = false;
			'    this.buttonDock.Enabled = true;
			'    this.buttonPin.Enabled = false;
			'    this.buttonUnpin.Enabled = false;
			'}
		End Sub

		Private Sub InitializeComponent()
			Me.groupBox = New GroupBox()
			Me.buttonClose = New Button()
			Me.buttonUnpin = New Button()
			Me.buttonPin = New Button()
			Me.buttonFloat = New Button()
			Me.buttonDock = New Button()
			Me.groupBox.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox
			' 
			Me.groupBox.Controls.Add(Me.buttonClose)
			Me.groupBox.Controls.Add(Me.buttonUnpin)
			Me.groupBox.Controls.Add(Me.buttonPin)
			Me.groupBox.Controls.Add(Me.buttonFloat)
			Me.groupBox.Controls.Add(Me.buttonDock)
			Me.groupBox.Location = New Point(18, 16)
			Me.groupBox.Name = "groupBox"
			Me.groupBox.Size = New Size(140, 170)
			Me.groupBox.TabIndex = 0
			Me.groupBox.TabStop = False
			Me.groupBox.Text = "Select an action:"
			' 
			' buttonClose
			' 
			Me.buttonClose.Location = New Point(30, 141)
			Me.buttonClose.Name = "buttonClose"
			Me.buttonClose.Size = New Size(75, 23)
			Me.buttonClose.TabIndex = 4
			Me.buttonClose.Text = "Close"
			Me.buttonClose.UseVisualStyleBackColor = True
'			Me.buttonClose.Click += New System.EventHandler(Me.buttonClose_Click)
			' 
			' buttonUnpin
			' 
			Me.buttonUnpin.Location = New Point(30, 111)
			Me.buttonUnpin.Name = "buttonUnpin"
			Me.buttonUnpin.Size = New Size(75, 23)
			Me.buttonUnpin.TabIndex = 3
			Me.buttonUnpin.Text = "Unpin"
			Me.buttonUnpin.UseVisualStyleBackColor = True
'			Me.buttonUnpin.Click += New System.EventHandler(Me.buttonUnpin_Click)
			' 
			' buttonPin
			' 
			Me.buttonPin.Enabled = False
			Me.buttonPin.Location = New Point(30, 81)
			Me.buttonPin.Name = "buttonPin"
			Me.buttonPin.Size = New Size(75, 23)
			Me.buttonPin.TabIndex = 2
			Me.buttonPin.Text = "Pin"
			Me.buttonPin.UseVisualStyleBackColor = True
'			Me.buttonPin.Click += New System.EventHandler(Me.buttonPin_Click)
			' 
			' buttonFloat
			' 
			Me.buttonFloat.Location = New Point(30, 51)
			Me.buttonFloat.Name = "buttonFloat"
			Me.buttonFloat.Size = New Size(75, 23)
			Me.buttonFloat.TabIndex = 1
			Me.buttonFloat.Text = "Float"
			Me.buttonFloat.UseVisualStyleBackColor = True
'			Me.buttonFloat.Click += New System.EventHandler(Me.buttonFloat_Click)
			' 
			' buttonDock
			' 
			Me.buttonDock.Enabled = False
			Me.buttonDock.Location = New Point(30, 21)
			Me.buttonDock.Name = "buttonDock"
			Me.buttonDock.Size = New Size(75, 23)
			Me.buttonDock.TabIndex = 0
			Me.buttonDock.Text = "Dock"
			Me.buttonDock.UseVisualStyleBackColor = True
'			Me.buttonDock.Click += New System.EventHandler(Me.buttonDock_Click)
			' 
			' ProgrammableToolWnd
			' 
			Me.BackColor = Color.White
			Me.Controls.Add(Me.groupBox)
			Me.Location = New Point(0, 26)
			Me.Name = "ProgrammableToolWnd"
			Me.Size = New Size(184, 201)
			Me.groupBox.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		Private Sub buttonDock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonDock.Click
			Me.buttonFloat.Enabled = True
			Me.buttonDock.Enabled = False
			Me.buttonUnpin.Enabled = True
		End Sub

		Private Sub buttonFloat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFloat.Click
			Me.buttonFloat.Enabled = False
			Me.buttonDock.Enabled = True
			Me.buttonPin.Enabled = False
			Me.buttonUnpin.Enabled = False

			Dim rect As New Rectangle(Control.MousePosition, Me.Size)
		End Sub

		Private Sub buttonPin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPin.Click
			Me.buttonPin.Enabled = False
			Me.buttonUnpin.Enabled = True
		End Sub

		Private Sub buttonUnpin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonUnpin.Click
			Me.buttonPin.Enabled = True
			Me.buttonUnpin.Enabled = False
			Me.buttonFloat.Enabled = False
		End Sub

		Private Sub buttonClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClose.Click

		End Sub

		Default Public ReadOnly Property Item(ByVal buttonName As String) As Button
			Get
				Return actionButtons(buttonName)
			End Get
		End Property
	End Class
End Namespace
