Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
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
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListChartType = New Telerik.WinControls.UI.RadDropDownList()
			Me.orientationCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxSpline = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListChartType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orientationCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxSpline, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 1)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxSpline)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.orientationCheckBox)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownListChartType)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel1)
			Me.settingsPanel.PanelContainer.Size = New Size(240, 883)
			Me.settingsPanel.Size = New Size(240, 883)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.MinimumSize = New Size(550, 320)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(550, 320)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.ShowToolTip = True
			Me.radChartView1.Size = New Size(1230, 786)
			Me.radChartView1.TabIndex = 1
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 45)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(62, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Series type:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 148)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(106, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "Change Orientation:"
			' 
			' radDropDownListChartType
			' 
			Me.radDropDownListChartType.Anchor = AnchorStyles.Top
			Me.radDropDownListChartType.DropDownAnimationEnabled = False
			Me.radDropDownListChartType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "Range"
			radListDataItem2.Text = "RangeBar"
			Me.radDropDownListChartType.Items.Add(radListDataItem1)
			Me.radDropDownListChartType.Items.Add(radListDataItem2)
			Me.radDropDownListChartType.Location = New Point(5, 69)
			Me.radDropDownListChartType.Name = "radDropDownListChartType"
			Me.radDropDownListChartType.Size = New Size(230, 20)
			Me.radDropDownListChartType.TabIndex = 2
			' 
			' orientationCheckBox
			' 
			Me.orientationCheckBox.Anchor = AnchorStyles.Top
			Me.orientationCheckBox.Location = New Point(5, 172)
			Me.orientationCheckBox.Name = "orientationCheckBox"
			Me.orientationCheckBox.Size = New Size(72, 18)
			Me.orientationCheckBox.TabIndex = 4
			Me.orientationCheckBox.Text = "Horizontal"
			' 
			' radCheckBoxSpline
			' 
			Me.radCheckBoxSpline.Anchor = AnchorStyles.Top
			Me.radCheckBoxSpline.Enabled = False
			Me.radCheckBoxSpline.Location = New Point(5, 114)
			Me.radCheckBoxSpline.Name = "radCheckBoxSpline"
			Me.radCheckBoxSpline.Size = New Size(51, 18)
			Me.radCheckBoxSpline.TabIndex = 5
			Me.radCheckBoxSpline.Text = "Spline"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.AutoScrollMinSize = New Size(550, 320)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1240, 796)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListChartType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orientationCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxSpline, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private orientationCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private radDropDownListChartType As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radCheckBoxSpline As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
