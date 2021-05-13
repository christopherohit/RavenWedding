Namespace Telerik.Examples.WinControls.PageView.StripView.AddNewItem
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
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.stripAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.newItemVisibilityCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.shrinkItemsCheck = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.newItemVisibilityCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.shrinkItemsCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.shrinkItemsCheck)
			Me.settingsPanel.Controls.Add(Me.newItemVisibilityCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.stripAlignCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New Point(1068, 1)
			Me.settingsPanel.Size = New Size(200, 443)

			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.stripAlignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.newItemVisibilityCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.shrinkItemsCheck, 0)
			' 
			' radPageView1
			' 
            Me.radPageView1.Location = New Point(20, 20)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.Size = New Size(640, 328)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 85)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(61, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Strip Align:"
			' 
			' stripAlignCombo
			' 
			Me.stripAlignCombo.Anchor = AnchorStyles.Top
			Me.stripAlignCombo.DropDownAnimationEnabled = False
			Me.stripAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.stripAlignCombo.Location = New Point(10, 107)
			Me.stripAlignCombo.Name = "stripAlignCombo"
			Me.stripAlignCombo.Size = New Size(180, 20)
			Me.stripAlignCombo.TabIndex = 3

			' 
			' newItemVisibilityCombo
			' 
			Me.newItemVisibilityCombo.Anchor = AnchorStyles.Top
			Me.newItemVisibilityCombo.DropDownAnimationEnabled = False
			Me.newItemVisibilityCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.newItemVisibilityCombo.Location = New Point(10, 59)
			Me.newItemVisibilityCombo.Name = "newItemVisibilityCombo"
			Me.newItemVisibilityCombo.Size = New Size(180, 20)
			Me.newItemVisibilityCombo.TabIndex = 5

			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(10, 37)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(102, 18)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "New Item Visibility:"
			' 
			' shrinkItemsCheck
			' 
			Me.shrinkItemsCheck.Anchor = AnchorStyles.Top
			Me.shrinkItemsCheck.Location = New Point(10, 142)
			Me.shrinkItemsCheck.Name = "shrinkItemsCheck"
			Me.shrinkItemsCheck.Size = New Size(82, 18)
			Me.shrinkItemsCheck.TabIndex = 6
			Me.shrinkItemsCheck.Text = "Shrink Items"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New Size(1029, 755)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.newItemVisibilityCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.shrinkItemsCheck, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private stripAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private newItemVisibilityCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private shrinkItemsCheck As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
