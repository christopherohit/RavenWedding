Namespace Telerik.Examples.WinControls.PdfProcessing.PdfChartIntegration
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.checkBoxQ1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxQ2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxQ3 = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBoxQ4 = New Telerik.WinControls.UI.RadCheckBox()
            Me.dropDownListNumberOfProducts = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.chartValueStepEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.buttonSave = New Telerik.WinControls.UI.RadButton()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxQ1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxQ2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxQ3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxQ4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dropDownListNumberOfProducts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartValueStepEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonSave, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(561, 44)
            Me.checkBoxQ1.Location = New System.Drawing.Point(19, 44)
            Me.checkBoxQ1.Name = "checkBoxQ1"
            Me.checkBoxQ1.Size = New System.Drawing.Size(35, 18)
            Me.checkBoxQ1.TabIndex = 0
            Me.checkBoxQ1.Text = "Q1"
            Me.checkBoxQ2.Location = New System.Drawing.Point(138, 44)
            Me.checkBoxQ2.Name = "checkBoxQ2"
            Me.checkBoxQ2.Size = New System.Drawing.Size(35, 18)
            Me.checkBoxQ2.TabIndex = 1
            Me.checkBoxQ2.Text = "Q2"
            Me.checkBoxQ3.Location = New System.Drawing.Point(258, 44)
            Me.checkBoxQ3.Name = "checkBoxQ3"
            Me.checkBoxQ3.Size = New System.Drawing.Size(35, 18)
            Me.checkBoxQ3.TabIndex = 2
            Me.checkBoxQ3.Text = "Q3"
            Me.checkBoxQ4.Location = New System.Drawing.Point(378, 44)
            Me.checkBoxQ4.Name = "checkBoxQ4"
            Me.checkBoxQ4.Size = New System.Drawing.Size(35, 18)
            Me.checkBoxQ4.TabIndex = 3
            Me.checkBoxQ4.Text = "Q4"
            Me.dropDownListNumberOfProducts.DropDownAnimationEnabled = False
            Me.dropDownListNumberOfProducts.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Text = "1"
            radListDataItem2.Text = "2"
            radListDataItem3.Text = "3"
            radListDataItem4.Text = "4"
            radListDataItem5.Text = "5"
            radListDataItem6.Text = "6"
            Me.dropDownListNumberOfProducts.Items.Add(radListDataItem1)
            Me.dropDownListNumberOfProducts.Items.Add(radListDataItem2)
            Me.dropDownListNumberOfProducts.Items.Add(radListDataItem3)
            Me.dropDownListNumberOfProducts.Items.Add(radListDataItem4)
            Me.dropDownListNumberOfProducts.Items.Add(radListDataItem5)
            Me.dropDownListNumberOfProducts.Items.Add(radListDataItem6)
            Me.dropDownListNumberOfProducts.Location = New System.Drawing.Point(20, 107)
            Me.dropDownListNumberOfProducts.Name = "dropDownListNumberOfProducts"
            Me.dropDownListNumberOfProducts.Size = New System.Drawing.Size(123, 20)
            Me.dropDownListNumberOfProducts.TabIndex = 5
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel1.Location = New System.Drawing.Point(16, 80)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(127, 21)
            Me.radLabel1.TabIndex = 6
            Me.radLabel1.Text = "Number of Products"
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pictureBox1.Location = New System.Drawing.Point(20, 198)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(480, 305)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 7
            Me.pictureBox1.TabStop = False
            Me.chartValueStepEditor.Increment = New Decimal(New Integer() {500, 0, 0, 0})
            Me.chartValueStepEditor.Location = New System.Drawing.Point(258, 107)
            Me.chartValueStepEditor.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.chartValueStepEditor.Minimum = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.chartValueStepEditor.Name = "chartValueStepEditor"
            Me.chartValueStepEditor.NullableValue = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.chartValueStepEditor.Size = New System.Drawing.Size(122, 20)
            Me.chartValueStepEditor.TabIndex = 8
            Me.chartValueStepEditor.TabStop = False
            Me.chartValueStepEditor.Value = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel2.Location = New System.Drawing.Point(257, 80)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(106, 21)
            Me.radLabel2.TabIndex = 7
            Me.radLabel2.Text = "Chart Value Step"
            Me.buttonSave.Location = New System.Drawing.Point(20, 151)
            Me.buttonSave.Name = "buttonSave"
            Me.buttonSave.Size = New System.Drawing.Size(480, 24)
            Me.buttonSave.TabIndex = 9
            Me.buttonSave.Text = "Save Document"
            AddHandler Me.buttonSave.Click, New System.EventHandler(AddressOf Me.buttonSave_Click)
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel3.Location = New System.Drawing.Point(17, 20)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(59, 21)
            Me.radLabel3.TabIndex = 10
            Me.radLabel3.Text = "Quarters"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radLabel3)
            Me.Controls.Add(Me.checkBoxQ4)
            Me.Controls.Add(Me.checkBoxQ1)
            Me.Controls.Add(Me.checkBoxQ3)
            Me.Controls.Add(Me.checkBoxQ2)
            Me.Controls.Add(Me.buttonSave)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.chartValueStepEditor)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.radLabel1)
            Me.Controls.Add(Me.dropDownListNumberOfProducts)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            Me.Controls.SetChildIndex(Me.dropDownListNumberOfProducts, 0)
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.pictureBox1, 0)
            Me.Controls.SetChildIndex(Me.chartValueStepEditor, 0)
            Me.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.Controls.SetChildIndex(Me.buttonSave, 0)
            Me.Controls.SetChildIndex(Me.checkBoxQ2, 0)
            Me.Controls.SetChildIndex(Me.checkBoxQ3, 0)
            Me.Controls.SetChildIndex(Me.checkBoxQ1, 0)
            Me.Controls.SetChildIndex(Me.checkBoxQ4, 0)
            Me.Controls.SetChildIndex(Me.radLabel3, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxQ1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxQ2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxQ3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxQ4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dropDownListNumberOfProducts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartValueStepEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonSave, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private checkBoxQ1 As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxQ2 As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxQ3 As Telerik.WinControls.UI.RadCheckBox
        Private checkBoxQ4 As Telerik.WinControls.UI.RadCheckBox
        Private dropDownListNumberOfProducts As Telerik.WinControls.UI.RadDropDownList
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private chartValueStepEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private buttonSave As Telerik.WinControls.UI.RadButton
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
