Namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radTabbedFormControl1 = New Telerik.WinControls.UI.RadTabbedFormControl()
            Me.radTabbedFormControlTab1 = New Telerik.WinControls.UI.RadTabbedFormControlTab()
            Me.radTabbedFormControlTab2 = New Telerik.WinControls.UI.RadTabbedFormControlTab()
            Me.radTabbedFormControlTab3 = New Telerik.WinControls.UI.RadTabbedFormControlTab()
            Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radToggleButtonElement1 = New Telerik.WinControls.UI.RadToggleButtonElement()
            CType((Me.radTabbedFormControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radTabbedFormControl1.SuspendLayout()
            Me.radTabbedFormControlTab1.SuspendLayout()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radTabbedFormControl1.Controls.Add(Me.radTabbedFormControlTab1)
            Me.radTabbedFormControl1.Controls.Add(Me.radTabbedFormControlTab2)
            Me.radTabbedFormControl1.Controls.Add(Me.radTabbedFormControlTab3)
            Me.radTabbedFormControl1.LeftItems.AddRange(New Telerik.WinControls.RadItem() {Me.radToggleButtonElement1})
            Me.radTabbedFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.radTabbedFormControl1.Name = "radTabbedFormControl1"
            Me.radTabbedFormControl1.SelectedTab = Me.radTabbedFormControlTab1
            Me.radTabbedFormControl1.Size = New System.Drawing.Size(1592, 1044)
            Me.radTabbedFormControl1.TabIndex = 0
            Me.radTabbedFormControl1.Text = "RadTabbedForm"
            AddHandler Me.radTabbedFormControl1.TabAdded, New System.EventHandler(Of Telerik.WinControls.UI.RadTabbedFormControlEventArgs)(AddressOf Me.radTabbedFormControl1_TabAdded)
            AddHandler Me.radTabbedFormControl1.SelectedTabChanged, New System.EventHandler(AddressOf Me.radTabbedFormControl1_SelectedTabChanged)
            Me.radTabbedFormControlTab1.Location = New System.Drawing.Point(1, 31)
            Me.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1"
            Me.radTabbedFormControlTab1.Size = New System.Drawing.Size(1590, 1012)
            Me.radTabbedFormControlTab1.Text = "Google"
            Me.radTabbedFormControlTab2.Location = New System.Drawing.Point(1, 31)
            Me.radTabbedFormControlTab2.Name = "radTabbedFormControlTab2"
            Me.radTabbedFormControlTab2.Size = New System.Drawing.Size(1590, 1012)
            Me.radTabbedFormControlTab2.Text = "Tab 2"
            Me.radTabbedFormControlTab3.Location = New System.Drawing.Point(1, 31)
            Me.radTabbedFormControlTab3.Name = "radTabbedFormControlTab3"
            Me.radTabbedFormControlTab3.Size = New System.Drawing.Size(1590, 1012)
            Me.radTabbedFormControlTab3.Text = "Tab 3"
            Me.radButtonElement1.Enabled = True
            Me.radButtonElement1.Name = "radButtonElement1"
            Me.radButtonElement1.StretchHorizontally = False
            Me.radButtonElement1.StretchVertically = False
            Me.radButtonElement1.Text = "Btn"
            Me.radToggleButtonElement1.Enabled = True
            Me.radToggleButtonElement1.Name = "radToggleButtonElement1"
            Me.radToggleButtonElement1.[ReadOnly] = False
            Me.radToggleButtonElement1.Text = "RadForm"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(1200, 700)
            Me.Controls.Add(Me.radTabbedFormControl1)
            Me.Name = "Form1"
            Me.RootElement.ApplyShapeToControl = True
            Me.ShowIcon = False
            Me.Text = "RadTabbedForm"
            CType((Me.radTabbedFormControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radTabbedFormControl1.ResumeLayout(False)
            Me.radTabbedFormControlTab1.ResumeLayout(False)
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radTabbedFormControl1 As Telerik.WinControls.UI.RadTabbedFormControl
        Private radTabbedFormControlTab1 As Telerik.WinControls.UI.RadTabbedFormControlTab
        Private radTabbedFormControlTab2 As Telerik.WinControls.UI.RadTabbedFormControlTab
        Private radTabbedFormControlTab3 As Telerik.WinControls.UI.RadTabbedFormControlTab
        Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
        Private radToggleButtonElement1 As Telerik.WinControls.UI.RadToggleButtonElement
    End Class
End Namespace
