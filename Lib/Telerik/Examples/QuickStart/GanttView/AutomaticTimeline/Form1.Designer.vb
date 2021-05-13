Namespace Telerik.Examples.WinControls.GanttView.AutomaticTimeline
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
        Me.radGanttView2 = New Telerik.WinControls.UI.RadGanttView()
        Me.radTrackBarZoom = New Telerik.WinControls.UI.RadTrackBar()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.settingsPanel,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.radGanttView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.radGanttView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.radTrackBarZoom,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'radGanttView1
        '
        Me.radGanttView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.radGanttView1.Location = New System.Drawing.Point(12, 258)
        Me.radGanttView1.Name = "radGanttView1"
        Me.radGanttView1.Ratio = 0.004!
        Me.radGanttView1.Size = New System.Drawing.Size(1838, 81)
        Me.radGanttView1.SplitterWidth = 7
        Me.radGanttView1.TabIndex = 0
        Me.radGanttView1.Text = "radGanttView1"
        CType(Me.radGanttView1.GetChildAt(0),Telerik.WinControls.UI.RadGanttViewElement).SplitterWidth = 7
        CType(Me.radGanttView1.GetChildAt(0).GetChildAt(0),Telerik.WinControls.UI.GanttViewTextViewElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.radGanttView1.GetChildAt(0).GetChildAt(1),Telerik.WinControls.UI.GanttViewViewsSplitterElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'radGanttView2
        '
        Me.radGanttView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.radGanttView2.Location = New System.Drawing.Point(12, 453)
        Me.radGanttView2.Name = "radGanttView2"
        Me.radGanttView2.Ratio = 0.004!
        Me.radGanttView2.Size = New System.Drawing.Size(1838, 80)
        Me.radGanttView2.SplitterWidth = 7
        Me.radGanttView2.TabIndex = 0
        Me.radGanttView2.Text = "radGanttView1"
        CType(Me.radGanttView2.GetChildAt(0),Telerik.WinControls.UI.RadGanttViewElement).SplitterWidth = 7
        CType(Me.radGanttView2.GetChildAt(0).GetChildAt(0),Telerik.WinControls.UI.GanttViewTextViewElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.radGanttView2.GetChildAt(0).GetChildAt(1),Telerik.WinControls.UI.GanttViewViewsSplitterElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'radTrackBarZoom
        '
        Me.radTrackBarZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.radTrackBarZoom.AutoSize = false
        Me.radTrackBarZoom.Location = New System.Drawing.Point(22, 629)
        Me.radTrackBarZoom.Maximum = 31!
        Me.radTrackBarZoom.Name = "radTrackBarZoom"
        Me.radTrackBarZoom.Size = New System.Drawing.Size(1828, 37)
        Me.radTrackBarZoom.TabIndex = 1
        Me.radTrackBarZoom.Text = "radTrackBar1"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 18!)
        Me.RadLabel1.Location = New System.Drawing.Point(22, 195)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(220, 37)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Static timeline view"
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 18!)
        Me.RadLabel2.Location = New System.Drawing.Point(22, 390)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(273, 37)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Automatic timeline view"
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 18!)
        Me.RadLabel3.Location = New System.Drawing.Point(22, 566)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 37)
        Me.RadLabel3.TabIndex = 3
        Me.RadLabel3.Text = "Zoom"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.radTrackBarZoom)
        Me.Controls.Add(Me.radGanttView2)
        Me.Controls.Add(Me.radGanttView1)
        Me.Name = "Form1"
        Me.Size = New System.Drawing.Size(1856, 999)
        Me.Controls.SetChildIndex(Me.radGanttView1, 0)
        Me.Controls.SetChildIndex(Me.radGanttView2, 0)
        Me.Controls.SetChildIndex(Me.radTrackBarZoom, 0)
        Me.Controls.SetChildIndex(Me.settingsPanel, 0)
        Me.Controls.SetChildIndex(Me.RadLabel1, 0)
        Me.Controls.SetChildIndex(Me.RadLabel2, 0)
        Me.Controls.SetChildIndex(Me.RadLabel3, 0)
        CType(Me.settingsPanel,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.radGanttView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.radGanttView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.radTrackBarZoom,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

		#End Region

		Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
		Private radGanttView2 As Telerik.WinControls.UI.RadGanttView
        Private WithEvents radTrackBarZoom As Telerik.WinControls.UI.RadTrackBar
        Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
