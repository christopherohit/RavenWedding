Namespace Telerik.Examples.WinControls.GridView.ManipulateData.IndicateErrors
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radButtonSet = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorRow = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorColumn = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBoxRowError = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBoxCellError = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonClear = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorRow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorColumn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxRowError, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxCellError, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(826, 1)
			Me.settingsPanel.Size = New Size(200, 668)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(1029, 602)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' radButtonSet
			' 
			Me.radButtonSet.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radButtonSet.Location = New Point(13, 328)
			Me.radButtonSet.Name = "radButtonSet"
			Me.radButtonSet.Size = New Size(154, 24)
			Me.radButtonSet.TabIndex = 1
			Me.radButtonSet.Text = "Set"

			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(13, 32)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(30, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Row:"
			' 
			' radSpinEditorRow
			' 
			Me.radSpinEditorRow.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radSpinEditorRow.Location = New Point(13, 52)
			Me.radSpinEditorRow.Name = "radSpinEditorRow"
			' 
			' 
			' 
			Me.radSpinEditorRow.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorRow.Size = New Size(154, 20)
			Me.radSpinEditorRow.TabIndex = 3
			Me.radSpinEditorRow.TabStop = False

			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(13, 78)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(48, 18)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "Column:"
			' 
			' radSpinEditorColumn
			' 
			Me.radSpinEditorColumn.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radSpinEditorColumn.Location = New Point(13, 98)
			Me.radSpinEditorColumn.Name = "radSpinEditorColumn"
			' 
			' 
			' 
			Me.radSpinEditorColumn.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorColumn.Size = New Size(154, 20)
			Me.radSpinEditorColumn.TabIndex = 5
			Me.radSpinEditorColumn.TabStop = False

			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(13, 124)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(80, 18)
			Me.radLabel3.TabIndex = 6
			Me.radLabel3.Text = "Row error text:"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(13, 221)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(76, 18)
			Me.radLabel4.TabIndex = 7
			Me.radLabel4.Text = "Cell error text:"
			' 
			' radTextBoxRowError
			' 
			Me.radTextBoxRowError.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radTextBoxRowError.AutoSize = False
			Me.radTextBoxRowError.Location = New Point(13, 144)
			Me.radTextBoxRowError.Multiline = True
			Me.radTextBoxRowError.Name = "radTextBoxRowError"
			Me.radTextBoxRowError.Size = New Size(154, 71)
			Me.radTextBoxRowError.TabIndex = 8
			Me.radTextBoxRowError.TabStop = False
			' 
			' radTextBoxCellError
			' 
			Me.radTextBoxCellError.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radTextBoxCellError.AutoSize = False
			Me.radTextBoxCellError.Location = New Point(13, 241)
			Me.radTextBoxCellError.Multiline = True
			Me.radTextBoxCellError.Name = "radTextBoxCellError"
			Me.radTextBoxCellError.Size = New Size(154, 71)
			Me.radTextBoxCellError.TabIndex = 9
			Me.radTextBoxCellError.TabStop = False
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButtonClear)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.radTextBoxCellError)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorRow)
			Me.radGroupBox1.Controls.Add(Me.radTextBoxRowError)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorColumn)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radButtonSet)
			Me.radGroupBox1.HeaderText = "Set custom error text:"
			Me.radGroupBox1.Location = New Point(10, 49)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 394)
			Me.radGroupBox1.TabIndex = 10
			Me.radGroupBox1.Text = "Set custom error text:"
			' 
			' radButtonClear
			' 
			Me.radButtonClear.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radButtonClear.Location = New Point(13, 358)
			Me.radButtonClear.Name = "radButtonClear"
			Me.radButtonClear.Size = New Size(154, 24)
			Me.radButtonClear.TabIndex = 10
			Me.radButtonClear.Text = "Clear"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(1029, 602)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorRow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorColumn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxRowError, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxCellError, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radButtonSet As Telerik.WinControls.UI.RadButton
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorColumn As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorRow As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radTextBoxCellError As Telerik.WinControls.UI.RadTextBox
		Private radTextBoxRowError As Telerik.WinControls.UI.RadTextBox
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radButtonClear As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
