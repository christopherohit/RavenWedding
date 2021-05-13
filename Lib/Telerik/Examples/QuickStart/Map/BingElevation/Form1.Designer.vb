Namespace Telerik.Examples.WinControls.Map.BingElevation
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radGroupBoxSetup = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonCalculateElevations = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditorColumns = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorRows = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabelColumns = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelRows = New Telerik.WinControls.UI.RadLabel()
			Me.radMap1 = New Telerik.WinControls.UI.RadMap()
			Me.radGroupBoxBoundsSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBoxPolylineSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabelNumberOfSamples = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorSamples = New Telerik.WinControls.UI.RadSpinEditor()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBoxSetup, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxSetup.SuspendLayout()
			CType(Me.radButtonCalculateElevations, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxBoundsSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxBoundsSettings.SuspendLayout()
			CType(Me.radGroupBoxPolylineSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxPolylineSettings.SuspendLayout()
			CType(Me.radLabelNumberOfSamples, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorSamples, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxPolylineSettings)
			Me.settingsPanel.Controls.Add(Me.radGroupBoxBoundsSettings)
			Me.settingsPanel.Controls.Add(Me.radGroupBoxSetup)
			Me.settingsPanel.Size = New Size(230, 710)
			Me.settingsPanel.TabStop = False
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxSetup, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxBoundsSettings, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxPolylineSettings, 0)
			' 
			' radGroupBoxSetup
			' 
			Me.radGroupBoxSetup.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxSetup.Anchor = AnchorStyles.Top
			Me.radGroupBoxSetup.Controls.Add(Me.radButtonCalculateElevations)
			Me.radGroupBoxSetup.Controls.Add(Me.radLabel1)
			Me.radGroupBoxSetup.Controls.Add(Me.radDropDownList1)
			Me.radGroupBoxSetup.HeaderText = "Elevation options"
			Me.radGroupBoxSetup.Location = New Point(10, 33)
			Me.radGroupBoxSetup.Name = "radGroupBoxSetup"
			Me.radGroupBoxSetup.Size = New Size(210, 131)
			Me.radGroupBoxSetup.TabIndex = 1
			Me.radGroupBoxSetup.TabStop = False
			Me.radGroupBoxSetup.Text = "Elevation options"
			' 
			' radButtonCalculateElevations
			' 
			Me.radButtonCalculateElevations.Anchor = AnchorStyles.Top
			Me.radButtonCalculateElevations.Location = New Point(5, 86)
			Me.radButtonCalculateElevations.Name = "radButtonCalculateElevations"
			Me.radButtonCalculateElevations.Size = New Size(200, 40)
			Me.radButtonCalculateElevations.TabIndex = 2
			Me.radButtonCalculateElevations.Text = "Calculate elevation(s)"
'			Me.radButtonCalculateElevations.Click += New System.EventHandler(Me.radButtonCalculateElevations_Click)
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 30)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(35, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Mode"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(5, 51)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(200, 20)
			Me.radDropDownList1.TabIndex = 0
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' radSpinEditorColumns
			' 
			Me.radSpinEditorColumns.Anchor = AnchorStyles.Top
			Me.radSpinEditorColumns.Location = New Point(5, 101)
			Me.radSpinEditorColumns.Maximum = New Decimal(New Integer() { 32, 0, 0, 0})
			Me.radSpinEditorColumns.Minimum = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.radSpinEditorColumns.Name = "radSpinEditorColumns"
			Me.radSpinEditorColumns.Size = New Size(200, 20)
			Me.radSpinEditorColumns.TabIndex = 3
			Me.radSpinEditorColumns.TabStop = False
			Me.radSpinEditorColumns.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			' 
			' radSpinEditorRows
			' 
			Me.radSpinEditorRows.Anchor = AnchorStyles.Top
			Me.radSpinEditorRows.Location = New Point(5, 51)
			Me.radSpinEditorRows.Maximum = New Decimal(New Integer() { 32, 0, 0, 0})
			Me.radSpinEditorRows.Minimum = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.radSpinEditorRows.Name = "radSpinEditorRows"
			Me.radSpinEditorRows.Size = New Size(200, 20)
			Me.radSpinEditorRows.TabIndex = 3
			Me.radSpinEditorRows.TabStop = False
			Me.radSpinEditorRows.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			' 
			' radLabelColumns
			' 
			Me.radLabelColumns.Anchor = AnchorStyles.Top
			Me.radLabelColumns.Location = New Point(5, 80)
			Me.radLabelColumns.Name = "radLabelColumns"
			Me.radLabelColumns.Size = New Size(49, 18)
			Me.radLabelColumns.TabIndex = 2
			Me.radLabelColumns.Text = "Columns"
			' 
			' radLabelRows
			' 
			Me.radLabelRows.Anchor = AnchorStyles.Top
			Me.radLabelRows.Location = New Point(5, 30)
			Me.radLabelRows.Name = "radLabelRows"
			Me.radLabelRows.Size = New Size(32, 18)
			Me.radLabelRows.TabIndex = 2
			Me.radLabelRows.Text = "Rows"
			' 
			' radMap1
			' 
			Me.radMap1.Dock = DockStyle.Fill
			Me.radMap1.Location = New Point(0, 0)
			Me.radMap1.Name = "radMap1"
			Me.radMap1.ShowLegend = False
			Me.radMap1.ShowSearchBar = False
			Me.radMap1.Size = New Size(1495, 1028)
			Me.radMap1.TabIndex = 2
			Me.radMap1.Text = "radMap1"
			' 
			' radGroupBoxBoundsSettings
			' 
			Me.radGroupBoxBoundsSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxBoundsSettings.Anchor = AnchorStyles.Top
			Me.radGroupBoxBoundsSettings.Controls.Add(Me.radSpinEditorColumns)
			Me.radGroupBoxBoundsSettings.Controls.Add(Me.radLabelRows)
			Me.radGroupBoxBoundsSettings.Controls.Add(Me.radSpinEditorRows)
			Me.radGroupBoxBoundsSettings.Controls.Add(Me.radLabelColumns)
			Me.radGroupBoxBoundsSettings.HeaderText = "Bounds settings"
			Me.radGroupBoxBoundsSettings.Location = New Point(10, 168)
			Me.radGroupBoxBoundsSettings.Name = "radGroupBoxBoundsSettings"
			Me.radGroupBoxBoundsSettings.Size = New Size(210, 131)
			Me.radGroupBoxBoundsSettings.TabIndex = 1
			Me.radGroupBoxBoundsSettings.Text = "Bounds settings"
			Me.radGroupBoxBoundsSettings.Visible = False
			' 
			' radGroupBoxPolylineSettings
			' 
			Me.radGroupBoxPolylineSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxPolylineSettings.Anchor = AnchorStyles.Top
			Me.radGroupBoxPolylineSettings.Controls.Add(Me.radLabelNumberOfSamples)
			Me.radGroupBoxPolylineSettings.Controls.Add(Me.radSpinEditorSamples)
			Me.radGroupBoxPolylineSettings.HeaderText = "Polyline settings"
			Me.radGroupBoxPolylineSettings.Location = New Point(10, 168)
			Me.radGroupBoxPolylineSettings.Name = "radGroupBoxPolylineSettings"
			Me.radGroupBoxPolylineSettings.Size = New Size(210, 80)
			Me.radGroupBoxPolylineSettings.TabIndex = 1
			Me.radGroupBoxPolylineSettings.Text = "Polyline settings"
			Me.radGroupBoxPolylineSettings.Visible = False
			' 
			' radLabelNumberOfSamples
			' 
			Me.radLabelNumberOfSamples.Anchor = AnchorStyles.Top
			Me.radLabelNumberOfSamples.Location = New Point(5, 30)
			Me.radLabelNumberOfSamples.Name = "radLabelNumberOfSamples"
			Me.radLabelNumberOfSamples.Size = New Size(103, 18)
			Me.radLabelNumberOfSamples.TabIndex = 2
			Me.radLabelNumberOfSamples.Text = "Number of samples"
			' 
			' radSpinEditorSamples
			' 
			Me.radSpinEditorSamples.Anchor = AnchorStyles.Top
			Me.radSpinEditorSamples.Location = New Point(5, 51)
			Me.radSpinEditorSamples.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.radSpinEditorSamples.Minimum = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.radSpinEditorSamples.Name = "radSpinEditorSamples"
			Me.radSpinEditorSamples.Size = New Size(200, 20)
			Me.radSpinEditorSamples.TabIndex = 3
			Me.radSpinEditorSamples.TabStop = False
			Me.radSpinEditorSamples.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radMap1)
			Me.Name = "Form1"
			Me.Size = New Size(1505, 1038)
			Me.Controls.SetChildIndex(Me.radMap1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGroupBoxSetup, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxSetup.ResumeLayout(False)
			Me.radGroupBoxSetup.PerformLayout()
			CType(Me.radButtonCalculateElevations, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorColumns, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelColumns, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxBoundsSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxBoundsSettings.ResumeLayout(False)
			Me.radGroupBoxBoundsSettings.PerformLayout()
			CType(Me.radGroupBoxPolylineSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxPolylineSettings.ResumeLayout(False)
			Me.radGroupBoxPolylineSettings.PerformLayout()
			CType(Me.radLabelNumberOfSamples, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorSamples, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBoxSetup As Telerik.WinControls.UI.RadGroupBox
		Private radSpinEditorColumns As Telerik.WinControls.UI.RadSpinEditor
		Private radSpinEditorRows As Telerik.WinControls.UI.RadSpinEditor
		Private radLabelColumns As Telerik.WinControls.UI.RadLabel
		Private radLabelRows As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radMap1 As Telerik.WinControls.UI.RadMap
		Private radGroupBoxBoundsSettings As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBoxPolylineSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLabelNumberOfSamples As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorSamples As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radButtonCalculateElevations As Telerik.WinControls.UI.RadButton
	End Class
End Namespace