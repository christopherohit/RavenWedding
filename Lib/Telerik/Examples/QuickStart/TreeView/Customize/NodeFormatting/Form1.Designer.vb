Namespace Telerik.Examples.WinControls.TreeView.Customize.NodeFormatting
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			If Me.boldFont IsNot Nothing Then
				Me.boldFont.Dispose()
				Me.boldFont = Nothing
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radCheckBoxFormatting = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxFormatting, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBoxFormatting)
			Me.settingsPanel.Location = New Point(982, 1)
			Me.settingsPanel.Size = New Size(200, 830)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxFormatting, 0)
			' 
			' btnSpy
			' 
			Me.btnSpy.Anchor = AnchorStyles.Top
			Me.btnSpy.Image = (CType(resources.GetObject("btnSpy.Image"), Image))
			Me.btnSpy.Location = New Point(10, 7)
			Me.btnSpy.Name = "btnSpy"
			Me.btnSpy.Padding = New Padding(2, 0, 0, 0)
			' 
			' 
			' 
			Me.btnSpy.RootElement.Padding = New Padding(2, 0, 0, 0)
			Me.btnSpy.Size = New Size(180, 24)
			Me.btnSpy.TabIndex = 0
			Me.btnSpy.Text = "RadControl Spy "
			Me.btnSpy.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New Size(420, 415)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 0
			' 
			' radCheckBoxFormatting
			' 
			Me.radCheckBoxFormatting.Anchor = AnchorStyles.Top
			Me.radCheckBoxFormatting.Location = New Point(10, 38)
			Me.radCheckBoxFormatting.Name = "radCheckBoxFormatting"
			Me.radCheckBoxFormatting.Size = New Size(110, 18)
			Me.radCheckBoxFormatting.TabIndex = 1
			Me.radCheckBoxFormatting.Text = "Enable formatting"
			Me.radCheckBoxFormatting.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New Size(1029, 602)
			Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxFormatting, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private btnSpy As Telerik.WinControls.UI.RadButton
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radCheckBoxFormatting As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
