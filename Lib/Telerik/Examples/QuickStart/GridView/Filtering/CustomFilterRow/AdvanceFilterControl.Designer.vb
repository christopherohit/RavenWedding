Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
	Partial Public Class AdvanceFilterControl
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
			Me.radPageView = New Telerik.WinControls.UI.RadPageView()
			Me.radSearchPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabelSearch = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBoxSearch = New Telerik.WinControls.UI.RadTextBox()
			Me.radAdvancedPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radBtnAdvanceApply = New Telerik.WinControls.UI.RadButton()
			Me.rtbValue1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radDdlColumns = New Telerik.WinControls.UI.RadDropDownList()
			Me.radDropDownButtonOperator = New Telerik.WinControls.UI.RadDropDownButton()
			Me.radLabelFilter = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPageView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView.SuspendLayout()
			Me.radSearchPage.SuspendLayout()
			CType(Me.radLabelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radAdvancedPage.SuspendLayout()
			CType(Me.radBtnAdvanceApply, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rtbValue1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDdlColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownButtonOperator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPageView
			' 
			Me.radPageView.BackColor = Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(249))))))
			Me.radPageView.Controls.Add(Me.radSearchPage)
			Me.radPageView.Controls.Add(Me.radAdvancedPage)
			Me.radPageView.Dock = DockStyle.Fill
			Me.radPageView.Location = New Point(0, 0)
			Me.radPageView.Name = "radPageView"
			Me.radPageView.SelectedPage = Me.radAdvancedPage
			Me.radPageView.Size = New Size(496, 101)
			Me.radPageView.TabIndex = 0
			Me.radPageView.Text = "PageView"
			CType(Me.radPageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
			' 
			' radSearchPage
			' 
			Me.radSearchPage.Controls.Add(Me.radLabelSearch)
			Me.radSearchPage.Controls.Add(Me.radTextBoxSearch)
			Me.radSearchPage.Location = New Point(10, 37)
			Me.radSearchPage.Name = "radSearchPage"
			Me.radSearchPage.Size = New Size(475, 55)
			Me.radSearchPage.Text = "Search"
			' 
			' radLabelSearch
			' 
			Me.radLabelSearch.Location = New Point(3, 3)
			Me.radLabelSearch.Name = "radLabelSearch"
			Me.radLabelSearch.Size = New Size(128, 18)
			Me.radLabelSearch.TabIndex = 1
			Me.radLabelSearch.Text = "Type your search criteria"
			' 
			' radTextBoxSearch
			' 
			Me.radTextBoxSearch.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radTextBoxSearch.Location = New Point(3, 28)
			Me.radTextBoxSearch.Name = "radTextBoxSearch"
			Me.radTextBoxSearch.Size = New Size(469, 20)
			Me.radTextBoxSearch.TabIndex = 0
			Me.radTextBoxSearch.TabStop = False

			' 
			' radAdvancedPage
			' 
			Me.radAdvancedPage.Controls.Add(Me.radBtnAdvanceApply)
			Me.radAdvancedPage.Controls.Add(Me.rtbValue1)
			Me.radAdvancedPage.Controls.Add(Me.radDdlColumns)
			Me.radAdvancedPage.Controls.Add(Me.radDropDownButtonOperator)
			Me.radAdvancedPage.Controls.Add(Me.radLabelFilter)
			Me.radAdvancedPage.Location = New Point(10, 37)
			Me.radAdvancedPage.Name = "radAdvancedPage"
			Me.radAdvancedPage.Size = New Size(475, 55)
			Me.radAdvancedPage.Text = "Advanced"
			' 
			' radBtnAdvanceApply
			' 
            Me.radBtnAdvanceApply.Location = New Point(390, 28)
			Me.radBtnAdvanceApply.Name = "radBtnAdvanceApply"
			Me.radBtnAdvanceApply.Size = New Size(78, 21)
			Me.radBtnAdvanceApply.TabIndex = 10
            Me.radBtnAdvanceApply.Text = "Apply"
			' 
			' rtbValue1
            ' 
			Me.rtbValue1.Enabled = False
            Me.rtbValue1.Location = New Point(246, 28)
			Me.rtbValue1.Name = "rtbValue1"
			' 
			' 
			' 
            Me.rtbValue1.RootElement.Enabled = False
            Me.rtbValue1.Size = New Size(135, 21)
			Me.rtbValue1.TabIndex = 8
			Me.rtbValue1.TabStop = False

			' 
			' radDdlColumns
            ' 
			Me.radDdlColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDdlColumns.Location = New Point(3, 28)
			Me.radDdlColumns.Name = "radDdlColumns"
			Me.radDdlColumns.Size = New Size(123, 21)
            Me.radDdlColumns.TabIndex = 6
			' 
			' radDropDownButtonOperator
			' 
			Me.radDropDownButtonOperator.Location = New Point(132, 28)
            Me.radDropDownButtonOperator.Name = "radDropDownButtonOperator"
			Me.radDropDownButtonOperator.Size = New Size(106, 21)
			Me.radDropDownButtonOperator.TabIndex = 4
			Me.radDropDownButtonOperator.Text = "Equals"
			' 
			' radLabelFilter
			' 
			Me.radLabelFilter.Location = New Point(3, 3)
			Me.radLabelFilter.Name = "radLabelFilter"
			Me.radLabelFilter.Size = New Size(75, 18)
			Me.radLabelFilter.TabIndex = 1
			Me.radLabelFilter.Text = "Filter rows by:"
			' 
			' AdvanceFilterControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView)
			Me.Name = "AdvanceFilterControl"
			Me.Size = New Size(496, 103)
			CType(Me.radPageView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView.ResumeLayout(False)
			Me.radSearchPage.ResumeLayout(False)
			Me.radSearchPage.PerformLayout()
			CType(Me.radLabelSearch, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxSearch, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radAdvancedPage.ResumeLayout(False)
			Me.radAdvancedPage.PerformLayout()
			CType(Me.radBtnAdvanceApply, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rtbValue1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDdlColumns, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownButtonOperator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelFilter, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView As Telerik.WinControls.UI.RadPageView
		Private radSearchPage As Telerik.WinControls.UI.RadPageViewPage
		Private radTextBoxSearch As Telerik.WinControls.UI.RadTextBox
		Private radAdvancedPage As Telerik.WinControls.UI.RadPageViewPage
		Private radBtnAdvanceApply As Telerik.WinControls.UI.RadButton
		Private rtbValue1 As Telerik.WinControls.UI.RadTextBox
		Private radDdlColumns As Telerik.WinControls.UI.RadDropDownList
		Private radDropDownButtonOperator As Telerik.WinControls.UI.RadDropDownButton
		Private radLabelFilter As Telerik.WinControls.UI.RadLabel
		Private radLabelSearch As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
