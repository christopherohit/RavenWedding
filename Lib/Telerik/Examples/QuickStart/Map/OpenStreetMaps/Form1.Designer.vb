Namespace Telerik.Examples.WinControls.Map.OpenStreetMaps
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
			Me.radMap1 = New Telerik.WinControls.UI.RadMap()
			Me.radGroupBoxClusterStrategy = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownListClusterStrategy = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelClusterStrategy = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelDistance = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorDistance = New Telerik.WinControls.UI.RadSpinEditor()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxClusterStrategy, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxClusterStrategy.SuspendLayout()
			CType(Me.radDropDownListClusterStrategy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelClusterStrategy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelDistance, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorDistance, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxClusterStrategy)
			Me.settingsPanel.Size = New Size(230, 348)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxClusterStrategy, 0)
			' 
			' radMap1
			' 
			Me.radMap1.Dock = DockStyle.Fill
			Me.radMap1.Location = New Point(0, 0)
			Me.radMap1.Name = "radMap1"
			Me.radMap1.ShowLegend = False
			Me.radMap1.ShowMiniMap = False
			Me.radMap1.ShowSearchBar = False
			Me.radMap1.Size = New Size(1624, 1028)
			Me.radMap1.TabIndex = 0
			Me.radMap1.Text = "radMap1"
			' 
			' radGroupBoxClusterStrategy
			' 
			Me.radGroupBoxClusterStrategy.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxClusterStrategy.Anchor = AnchorStyles.Top
			Me.radGroupBoxClusterStrategy.Controls.Add(Me.radSpinEditorDistance)
			Me.radGroupBoxClusterStrategy.Controls.Add(Me.radLabelDistance)
			Me.radGroupBoxClusterStrategy.Controls.Add(Me.radLabelClusterStrategy)
			Me.radGroupBoxClusterStrategy.Controls.Add(Me.radDropDownListClusterStrategy)
			Me.radGroupBoxClusterStrategy.HeaderText = "Cluster Settings"
			Me.radGroupBoxClusterStrategy.Location = New Point(10, 32)
			Me.radGroupBoxClusterStrategy.Name = "radGroupBoxClusterStrategy"
			Me.radGroupBoxClusterStrategy.Size = New Size(210, 129)
			Me.radGroupBoxClusterStrategy.TabIndex = 1
			Me.radGroupBoxClusterStrategy.Text = "Cluster Settings"
			' 
			' radDropDownListClusterStrategy
			' 
			Me.radDropDownListClusterStrategy.Anchor = AnchorStyles.Top
			Me.radDropDownListClusterStrategy.Location = New Point(5, 50)
			Me.radDropDownListClusterStrategy.Name = "radDropDownListClusterStrategy"
			Me.radDropDownListClusterStrategy.Size = New Size(200, 20)
			Me.radDropDownListClusterStrategy.TabIndex = 0
			Me.radDropDownListClusterStrategy.Text = "Cluster Strategy"
            AddHandler Me.radDropDownListClusterStrategy.SelectedIndexChanged, AddressOf Me.radDropDownListClusterStrategy_SelectedIndexChanged
			Me.radDropDownListClusterStrategy.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radLabelClusterStrategy
			' 
			Me.radLabelClusterStrategy.Anchor = AnchorStyles.Top
			Me.radLabelClusterStrategy.Location = New Point(5, 29)
			Me.radLabelClusterStrategy.Name = "radLabelClusterStrategy"
			Me.radLabelClusterStrategy.Size = New Size(84, 18)
			Me.radLabelClusterStrategy.TabIndex = 1
			Me.radLabelClusterStrategy.Text = "Cluster Strategy"
			' 
			' radLabelDistance
			' 
			Me.radLabelDistance.Anchor = AnchorStyles.Top
			Me.radLabelDistance.Location = New Point(5, 79)
			Me.radLabelDistance.Name = "radLabelDistance"
			Me.radLabelDistance.Size = New Size(48, 18)
			Me.radLabelDistance.TabIndex = 2
			Me.radLabelDistance.Text = "Distance (px)"
			' 
			' radSpinEditorDistance
			' 
			Me.radSpinEditorDistance.Anchor = AnchorStyles.Top
			Me.radSpinEditorDistance.Location = New Point(5, 100)
			Me.radSpinEditorDistance.Name = "radSpinEditorDistance"
			Me.radSpinEditorDistance.Size = New Size(200, 20)
			Me.radSpinEditorDistance.TabIndex = 3
			Me.radSpinEditorDistance.TabStop = False
            Me.radSpinEditorDistance.Value = New Decimal(New Integer() {50, 0, 0, 0})
            AddHandler Me.radSpinEditorDistance.ValueChanged, AddressOf Me.radSpinEditorDistance_ValueChanged
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radMap1)
			Me.Name = "Form1"
			Me.Size = New Size(1634, 1038)
			Me.Controls.SetChildIndex(Me.radMap1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxClusterStrategy, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxClusterStrategy.ResumeLayout(False)
			Me.radGroupBoxClusterStrategy.PerformLayout()
			CType(Me.radDropDownListClusterStrategy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelClusterStrategy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelDistance, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorDistance, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMap1 As Telerik.WinControls.UI.RadMap
		Private radGroupBoxClusterStrategy As Telerik.WinControls.UI.RadGroupBox
        Private radSpinEditorDistance As Telerik.WinControls.UI.RadSpinEditor
		Private radLabelDistance As Telerik.WinControls.UI.RadLabel
		Private radLabelClusterStrategy As Telerik.WinControls.UI.RadLabel
        Private radDropDownListClusterStrategy As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace