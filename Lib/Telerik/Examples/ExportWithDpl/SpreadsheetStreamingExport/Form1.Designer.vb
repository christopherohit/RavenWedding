
Namespace ExportWithDpl.SpreadsheetStreamingExport
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
			Me.radLabelExportedCells = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelNumberOfExportedCells = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelExportTime = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelExportTimeElapsed = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelSeconds = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelCurrentMemory = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelMemory = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelMB = New Telerik.WinControls.UI.RadLabel()
			Me.radButtonExport = New Telerik.WinControls.UI.RadButton()
			Me.radProgressBarExportProgress = New Telerik.WinControls.UI.RadProgressBar()
			Me.radDropDownListExtension = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditorRowsCount = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabelExtension = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelRowsCount = New Telerik.WinControls.UI.RadLabel()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.flowLayoutPanel1.SuspendLayout()
			DirectCast(Me.radLabelExportedCells, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelNumberOfExportedCells, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelExportTime, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelExportTimeElapsed, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelCurrentMemory, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelMemory, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelMB, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButtonExport, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radProgressBarExportProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radDropDownListExtension, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorRowsCount, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelExtension, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabelRowsCount, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.pictureBox1.Image = DirectCast(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
			Me.pictureBox1.Location = New System.Drawing.Point(2, 46)
			Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(840, 366)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' radLabel1
			' 
			Me.radLabel1.Font = New System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(53)), CInt(CByte(187)), CInt(CByte(162)))
			Me.radLabel1.Location = New System.Drawing.Point(2, 7)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(255, 28)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Large Document Export"
			' 
			' flowLayoutPanel1
			' 
			Me.flowLayoutPanel1.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelExportedCells)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelNumberOfExportedCells)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelExportTime)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelExportTimeElapsed)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelSeconds)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelCurrentMemory)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelMemory)
			Me.flowLayoutPanel1.Controls.Add(Me.radLabelMB)
			Me.flowLayoutPanel1.Location = New System.Drawing.Point(2, 492)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Size = New System.Drawing.Size(840, 24)
			Me.flowLayoutPanel1.TabIndex = 13
			' 
			' radLabelExportedCells
			' 
			Me.radLabelExportedCells.Location = New System.Drawing.Point(3, 3)
			Me.radLabelExportedCells.Name = "radLabelExportedCells"
			Me.radLabelExportedCells.Size = New System.Drawing.Size(78, 18)
			Me.radLabelExportedCells.TabIndex = 1
			Me.radLabelExportedCells.Text = "Exported cells:"
			' 
			' radLabelNumberOfExportedCells
			' 
			Me.radLabelNumberOfExportedCells.Location = New System.Drawing.Point(87, 3)
			Me.radLabelNumberOfExportedCells.Name = "radLabelNumberOfExportedCells"
			Me.radLabelNumberOfExportedCells.Size = New System.Drawing.Size(12, 18)
			Me.radLabelNumberOfExportedCells.TabIndex = 1
			Me.radLabelNumberOfExportedCells.Text = "0"
			' 
			' radLabelExportTime
			' 
			Me.radLabelExportTime.Location = New System.Drawing.Point(105, 3)
			Me.radLabelExportTime.Name = "radLabelExportTime"
			Me.radLabelExportTime.Size = New System.Drawing.Size(66, 18)
			Me.radLabelExportTime.TabIndex = 1
			Me.radLabelExportTime.Text = "Export time:"
			' 
			' radLabelExportTimeElapsed
			' 
			Me.radLabelExportTimeElapsed.Location = New System.Drawing.Point(177, 3)
			Me.radLabelExportTimeElapsed.Name = "radLabelExportTimeElapsed"
			Me.radLabelExportTimeElapsed.Size = New System.Drawing.Size(12, 18)
			Me.radLabelExportTimeElapsed.TabIndex = 1
			Me.radLabelExportTimeElapsed.Text = "0"
			' 
			' radLabelSeconds
			' 
			Me.radLabelSeconds.Location = New System.Drawing.Point(195, 3)
			Me.radLabelSeconds.Name = "radLabelSeconds"
			Me.radLabelSeconds.Size = New System.Drawing.Size(11, 18)
			Me.radLabelSeconds.TabIndex = 1
			Me.radLabelSeconds.Text = "s"
			' 
			' radLabelCurrentMemory
			' 
			Me.radLabelCurrentMemory.Location = New System.Drawing.Point(212, 3)
			Me.radLabelCurrentMemory.Name = "radLabelCurrentMemory"
			Me.radLabelCurrentMemory.Size = New System.Drawing.Size(91, 18)
			Me.radLabelCurrentMemory.TabIndex = 1
			Me.radLabelCurrentMemory.Text = "Current memory:"
			' 
			' radLabelMemory
			' 
			Me.radLabelMemory.Location = New System.Drawing.Point(309, 3)
			Me.radLabelMemory.Name = "radLabelMemory"
			Me.radLabelMemory.Size = New System.Drawing.Size(12, 18)
			Me.radLabelMemory.TabIndex = 1
			Me.radLabelMemory.Text = "0"
			' 
			' radLabelMB
			' 
			Me.radLabelMB.Location = New System.Drawing.Point(327, 3)
			Me.radLabelMB.Name = "radLabelMB"
			Me.radLabelMB.Size = New System.Drawing.Size(23, 18)
			Me.radLabelMB.TabIndex = 1
			Me.radLabelMB.Text = "MB"
			' 
			' radButtonExport
			' 
			Me.radButtonExport.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radButtonExport.Location = New System.Drawing.Point(732, 433)
			Me.radButtonExport.Name = "radButtonExport"
			Me.radButtonExport.Size = New System.Drawing.Size(110, 24)
			Me.radButtonExport.TabIndex = 12
			Me.radButtonExport.Text = "Export document"
			' 
			' radProgressBarExportProgress
			' 
			Me.radProgressBarExportProgress.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.radProgressBarExportProgress.Location = New System.Drawing.Point(2, 462)
			Me.radProgressBarExportProgress.Name = "radProgressBarExportProgress"
			Me.radProgressBarExportProgress.Size = New System.Drawing.Size(840, 24)
			Me.radProgressBarExportProgress.TabIndex = 11
			' 
			' radDropDownListExtension
			' 
			Me.radDropDownListExtension.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me.radDropDownListExtension.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "Xlsx"
			radListDataItem2.Text = "Csv"
			Me.radDropDownListExtension.Items.Add(radListDataItem1)
			Me.radDropDownListExtension.Items.Add(radListDataItem2)
            Me.radDropDownListExtension.Location = New System.Drawing.Point(226, 433)
			Me.radDropDownListExtension.Name = "radDropDownListExtension"
			Me.radDropDownListExtension.Size = New System.Drawing.Size(125, 20)
			Me.radDropDownListExtension.TabIndex = 10
			Me.radDropDownListExtension.Text = "Xlsx"
			' 
			' radSpinEditorRowsCount
			' 
			Me.radSpinEditorRowsCount.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me.radSpinEditorRowsCount.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.radSpinEditorRowsCount.Location = New System.Drawing.Point(89, 433)
			Me.radSpinEditorRowsCount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
			Me.radSpinEditorRowsCount.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
			Me.radSpinEditorRowsCount.Name = "radSpinEditorRowsCount"
			Me.radSpinEditorRowsCount.Size = New System.Drawing.Size(57, 20)
			Me.radSpinEditorRowsCount.TabIndex = 9
			Me.radSpinEditorRowsCount.TabStop = False
			Me.radSpinEditorRowsCount.Value = New Decimal(New Integer() {10000, 0, 0, 0})
			' 
			' radLabelExtension
			' 
			Me.radLabelExtension.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me.radLabelExtension.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.radLabelExtension.Location = New System.Drawing.Point(159, 436)
			Me.radLabelExtension.Name = "radLabelExtension"
			Me.radLabelExtension.Size = New System.Drawing.Size(61, 18)
			Me.radLabelExtension.TabIndex = 7
			Me.radLabelExtension.Text = "Extension:"
			' 
			' radLabelRowsCount
			' 
			Me.radLabelRowsCount.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me.radLabelRowsCount.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.radLabelRowsCount.Location = New System.Drawing.Point(12, 436)
			Me.radLabelRowsCount.Name = "radLabelRowsCount"
			Me.radLabelRowsCount.Size = New System.Drawing.Size(71, 18)
			Me.radLabelRowsCount.TabIndex = 8
			Me.radLabelRowsCount.Text = "Rows count:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.SystemColors.Window
			Me.ClientSize = New System.Drawing.Size(846, 673)
			Me.Controls.Add(Me.flowLayoutPanel1)
			Me.Controls.Add(Me.radButtonExport)
			Me.Controls.Add(Me.radProgressBarExportProgress)
			Me.Controls.Add(Me.radDropDownListExtension)
			Me.Controls.Add(Me.radSpinEditorRowsCount)
			Me.Controls.Add(Me.radLabelExtension)
			Me.Controls.Add(Me.radLabelRowsCount)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.pictureBox1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.flowLayoutPanel1.ResumeLayout(False)
			Me.flowLayoutPanel1.PerformLayout()
			DirectCast(Me.radLabelExportedCells, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelNumberOfExportedCells, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelExportTime, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelExportTimeElapsed, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelSeconds, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelCurrentMemory, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelMemory, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelMB, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButtonExport, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radProgressBarExportProgress, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radDropDownListExtension, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorRowsCount, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelExtension, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabelRowsCount, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
		Private radLabelExportedCells As Telerik.WinControls.UI.RadLabel
		Private radLabelNumberOfExportedCells As Telerik.WinControls.UI.RadLabel
		Private radLabelExportTime As Telerik.WinControls.UI.RadLabel
		Private radLabelExportTimeElapsed As Telerik.WinControls.UI.RadLabel
		Private radLabelSeconds As Telerik.WinControls.UI.RadLabel
		Private radLabelCurrentMemory As Telerik.WinControls.UI.RadLabel
		Private radLabelMemory As Telerik.WinControls.UI.RadLabel
		Private radLabelMB As Telerik.WinControls.UI.RadLabel
		Private radButtonExport As Telerik.WinControls.UI.RadButton
		Private radProgressBarExportProgress As Telerik.WinControls.UI.RadProgressBar
		Private radDropDownListExtension As Telerik.WinControls.UI.RadDropDownList
		Private radSpinEditorRowsCount As Telerik.WinControls.UI.RadSpinEditor
		Private radLabelExtension As Telerik.WinControls.UI.RadLabel
		Private radLabelRowsCount As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace