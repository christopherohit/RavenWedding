Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.SyntaxHighlight
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
			Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
			Me.commandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
			Me.commandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
			Me.commandBarToggleButton1 = New Telerik.WinControls.UI.CommandBarToggleButton()
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			Me.commandBarDropDownList1 = New Telerik.WinControls.UI.CommandBarDropDownList()
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radCommandBar1
			' 
			Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
			Me.radCommandBar1.Name = "radCommandBar1"
			Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() { Me.commandBarRowElement1})
			Me.radCommandBar1.Size = New System.Drawing.Size(839, 55)
			Me.radCommandBar1.TabIndex = 0
			Me.radCommandBar1.Text = "radCommandBar1"
			' 
			' commandBarRowElement1
			' 
			Me.commandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
			Me.commandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() { Me.commandBarStripElement1})
			' 
			' commandBarStripElement1
			' 
			Me.commandBarStripElement1.DisplayName = "commandBarStripElement1"
			Me.commandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() { Me.commandBarDropDownList1, Me.commandBarToggleButton1})
			Me.commandBarStripElement1.Name = "commandBarStripElement1"
			Me.commandBarStripElement1.StretchHorizontally = True
			' 
			' commandBarToggleButton1
			' 
			Me.commandBarToggleButton1.AccessibleDescription = "commandBarToggleButton1"
			Me.commandBarToggleButton1.AccessibleName = "commandBarToggleButton1"
			Me.commandBarToggleButton1.DisplayName = "commandBarToggleButton1"
			Me.commandBarToggleButton1.Image = (CType(resources.GetObject("commandBarToggleButton1.Image"), System.Drawing.Image))
			Me.commandBarToggleButton1.MinSize = New System.Drawing.Size(50, 0)
			Me.commandBarToggleButton1.Name = "commandBarToggleButton1"
			Me.commandBarToggleButton1.Text = "commandBarToggleButton1"
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.IsReadOnly = True
			Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 55)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.Size = New System.Drawing.Size(839, 558)
			Me.radRichTextEditor1.TabIndex = 1
			Me.radRichTextEditor1.Text = "radRichTextEditor1"
			' 
			' commandBarDropDownList1
			' 
			Me.commandBarDropDownList1.DisplayName = "commandBarDropDownList1"
			Me.commandBarDropDownList1.DropDownAnimationEnabled = True
			Me.commandBarDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "XAML"
			radListDataItem2.Text = "C#"
			Me.commandBarDropDownList1.Items.Add(radListDataItem1)
			Me.commandBarDropDownList1.Items.Add(radListDataItem2)
			Me.commandBarDropDownList1.MaxDropDownItems = 0
			Me.commandBarDropDownList1.Name = "commandBarDropDownList1"
			Me.commandBarDropDownList1.Text = ""
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(839, 613)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.radCommandBar1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Syntax Highlight"
			CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
		Private commandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
		Private commandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
		Private WithEvents commandBarToggleButton1 As Telerik.WinControls.UI.CommandBarToggleButton
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private WithEvents commandBarDropDownList1 As Telerik.WinControls.UI.CommandBarDropDownList
	End Class
End Namespace