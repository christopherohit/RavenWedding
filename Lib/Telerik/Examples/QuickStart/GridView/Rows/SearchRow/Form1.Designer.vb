Namespace Telerik.Examples.WinControls.GridView.Rows.SearchRow
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
            Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.radCheckBoxShowClearButton = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxShowCloseButton = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxCloseOnEscape = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxDeferredSearch = New Telerik.WinControls.UI.RadCheckBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxShowClearButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxShowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxCloseOnEscape, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxDeferredSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radCheckBoxCloseOnEscape)
            Me.settingsPanel.Controls.Add(Me.radCheckBoxShowCloseButton)
            Me.settingsPanel.Controls.Add(Me.radCheckBoxShowClearButton)
            Me.settingsPanel.Controls.Add(Me.radCheckBoxDeferredSearch)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxShowClearButton, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxShowCloseButton, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxCloseOnEscape, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxDeferredSearch, 0)
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            ' 
            ' 
            ' 
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AllowSearchRow = True
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(1185, 990)
            Me.radGridView1.TabIndex = 0
            Me.radGridView1.Text = "radGridView1"
            ' 
            ' radCheckBoxShowClearButton
            ' 
            Me.radCheckBoxShowClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxShowClearButton.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowClearButton.Location = New System.Drawing.Point(10, 33)
            Me.radCheckBoxShowClearButton.Name = "radCheckBoxShowClearButton"
            Me.radCheckBoxShowClearButton.Size = New System.Drawing.Size(111, 18)
            Me.radCheckBoxShowClearButton.TabIndex = 1
            Me.radCheckBoxShowClearButton.Text = "Show clear button"
            Me.radCheckBoxShowClearButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxShowClearButton.ToggleStateChanged, AddressOf Me.radCheckBoxShowClearButton_ToggleStateChanged
            ' 
            ' radCheckBoxShowCloseButton
            ' 
            Me.radCheckBoxShowCloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxShowCloseButton.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowCloseButton.Location = New System.Drawing.Point(10, 58)
            Me.radCheckBoxShowCloseButton.Name = "radCheckBoxShowCloseButton"
            Me.radCheckBoxShowCloseButton.Size = New System.Drawing.Size(113, 18)
            Me.radCheckBoxShowCloseButton.TabIndex = 2
            Me.radCheckBoxShowCloseButton.Text = "Show close button"
            Me.radCheckBoxShowCloseButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxShowCloseButton.ToggleStateChanged, AddressOf Me.radCheckBoxShowCloseButton_ToggleStateChanged
            ' 
            ' radCheckBoxCloseOnEscape
            ' 
            Me.radCheckBoxCloseOnEscape.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxCloseOnEscape.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxCloseOnEscape.Location = New System.Drawing.Point(10, 83)
            Me.radCheckBoxCloseOnEscape.Name = "radCheckBoxCloseOnEscape"
            Me.radCheckBoxCloseOnEscape.Size = New System.Drawing.Size(101, 18)
            Me.radCheckBoxCloseOnEscape.TabIndex = 3
            Me.radCheckBoxCloseOnEscape.Text = "Close on escape"
            Me.radCheckBoxCloseOnEscape.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxCloseOnEscape.ToggleStateChanged, AddressOf Me.radCheckBoxCloseOnEscape_ToggleStateChanged
            ' 
            ' radCheckBoxDeferredSearch
            ' 
            Me.radCheckBoxDeferredSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxDeferredSearch.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxDeferredSearch.Location = New System.Drawing.Point(10, 83)
            Me.radCheckBoxDeferredSearch.Name = "radCheckBoxDeferredSearch"
            Me.radCheckBoxDeferredSearch.Size = New System.Drawing.Size(101, 18)
            Me.radCheckBoxDeferredSearch.TabIndex = 4
            Me.radCheckBoxDeferredSearch.Text = "Deferred search"
            Me.radCheckBoxDeferredSearch.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            AddHandler Me.radCheckBoxDeferredSearch.ToggleStateChanged, AddressOf Me.radCheckBoxDeferredSearch_ToggleStateChanged
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1195, 1000)
            Me.Controls.SetChildIndex(Me.radGridView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxShowClearButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxShowCloseButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxCloseOnEscape, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxDeferredSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private radCheckBoxCloseOnEscape As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowCloseButton As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowClearButton As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxDeferredSearch As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace