Namespace Telerik.Examples.WinControls.CheckedListBox.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim listViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1")
            Me.radCheckedListBox1 = New Telerik.WinControls.UI.RadCheckedListBox()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.radOrderButton = New Telerik.WinControls.UI.RadButton()
            Me.radClearAllButton = New Telerik.WinControls.UI.RadButton()
            Me.radCheckAllButton = New Telerik.WinControls.UI.RadButton()
            Me.radCheckSelectedButton = New Telerik.WinControls.UI.RadButton()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radListView2 = New Telerik.WinControls.UI.RadListView()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckedListBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radListView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radOrderButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radClearAllButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckAllButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckSelectedButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radListView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(1226, 32)
            Me.radCheckedListBox1.CheckBoxesAlignment = Telerik.WinControls.UI.CheckBoxesAlignment.Near
            Me.radCheckedListBox1.ItemSize = New System.Drawing.Size(0, 92)
            Me.radCheckedListBox1.Location = New System.Drawing.Point(6, 42)
            Me.radCheckedListBox1.Margin = New System.Windows.Forms.Padding(5)
            Me.radCheckedListBox1.MultiSelect = True
            Me.radCheckedListBox1.Name = "radCheckedListBox1"
            Me.radCheckedListBox1.Size = New System.Drawing.Size(370, 420)
            Me.radCheckedListBox1.TabIndex = 2
            Me.radCheckedListBox1.Text = "radCheckedListBox1"
            AddHandler Me.radCheckedListBox1.ItemCheckedChanged, AddressOf Me.radCheckedListBox1_ItemCheckedChanged
            Me.radListView1.AllowEdit = False
            Me.radListView1.ItemSpacing = -1
            Me.radListView1.Location = New System.Drawing.Point(386, 42)
            Me.radListView1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
            Me.radListView1.MultiSelect = True
            Me.radListView1.Name = "radListView1"
            Me.radListView1.ShowColumnHeaders = False
            Me.radListView1.ShowGridLines = True
            Me.radListView1.Size = New System.Drawing.Size(193, 212)
            Me.radListView1.TabIndex = 3
            Me.radListView1.Text = "radListView1"
            Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
            Me.radOrderButton.Location = New System.Drawing.Point(386, 286)
            Me.radOrderButton.Margin = New System.Windows.Forms.Padding(5)
            Me.radOrderButton.Name = "radOrderButton"
            Me.radOrderButton.Size = New System.Drawing.Size(193, 24)
            Me.radOrderButton.TabIndex = 5
            Me.radOrderButton.Text = "Finish order"
            AddHandler Me.radOrderButton.Click, AddressOf Me.radOrderButton_Click
            Me.radClearAllButton.Location = New System.Drawing.Point(386, 320)
            Me.radClearAllButton.Margin = New System.Windows.Forms.Padding(5)
            Me.radClearAllButton.Name = "radClearAllButton"
            Me.radClearAllButton.Size = New System.Drawing.Size(193, 24)
            Me.radClearAllButton.TabIndex = 6
            Me.radClearAllButton.Text = "Clear all"
            AddHandler Me.radClearAllButton.Click, AddressOf Me.radClearAllButton_Click
            Me.radCheckAllButton.Location = New System.Drawing.Point(8, 472)
            Me.radCheckAllButton.Margin = New System.Windows.Forms.Padding(5)
            Me.radCheckAllButton.Name = "radCheckAllButton"
            Me.radCheckAllButton.Size = New System.Drawing.Size(126, 24)
            Me.radCheckAllButton.TabIndex = 8
            Me.radCheckAllButton.Text = "Check all"
            AddHandler Me.radCheckAllButton.Click, AddressOf Me.radCheckAllButton_Click
            Me.radCheckSelectedButton.Location = New System.Drawing.Point(144, 472)
            Me.radCheckSelectedButton.Margin = New System.Windows.Forms.Padding(5)
            Me.radCheckSelectedButton.Name = "radCheckSelectedButton"
            Me.radCheckSelectedButton.Size = New System.Drawing.Size(126, 24)
            Me.radCheckSelectedButton.TabIndex = 9
            Me.radCheckSelectedButton.Text = "Check selected"
            AddHandler Me.radCheckSelectedButton.Click, AddressOf Me.radCheckSelectedButton_Click
            Me.radLabel2.BackColor = System.Drawing.Color.Transparent
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((87)))))), (CInt(((CByte((89)))))), (CInt(((CByte((82)))))))
            Me.radLabel2.Location = New System.Drawing.Point(8, 8)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(267, 30)
            Me.radLabel2.TabIndex = 11
            Me.radLabel2.Text = "What would you like to order?"
            Me.radListView2.AllowEdit = False
            listViewDataItem1.Key = "{ Total = ""Total:"", Price = $0.00}"
            listViewDataItem1.Tag = "{ Total = ""Total:"", Price = $0.00}"
            listViewDataItem1.Text = "ListViewItem 1"
            Me.radListView2.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {listViewDataItem1})
            Me.radListView2.ItemSize = New System.Drawing.Size(201, 20)
            Me.radListView2.ItemSpacing = -1
            Me.radListView2.Location = New System.Drawing.Point(386, 254)
            Me.radListView2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.radListView2.Name = "radListView2"
            Me.radListView2.ShowColumnHeaders = False
            Me.radListView2.ShowGridLines = True
            Me.radListView2.Size = New System.Drawing.Size(193, 22)
            Me.radListView2.TabIndex = 15
            Me.radListView2.Text = "radListView2"
            Me.radListView2.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
            Me.radListView2.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.Controls.Add(Me.radListView2)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.radCheckedListBox1)
            Me.Controls.Add(Me.radCheckSelectedButton)
            Me.Controls.Add(Me.radCheckAllButton)
            Me.Controls.Add(Me.radClearAllButton)
            Me.Controls.Add(Me.radOrderButton)
            Me.Controls.Add(Me.radListView1)
            Me.MinimumSize = New System.Drawing.Size(370, 420)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1540, 1000)
            AddHandler Me.Load, AddressOf Me.Form1_Load
            Me.Controls.SetChildIndex(Me.radListView1, 0)
            Me.Controls.SetChildIndex(Me.radOrderButton, 0)
            Me.Controls.SetChildIndex(Me.radClearAllButton, 0)
            Me.Controls.SetChildIndex(Me.radCheckAllButton, 0)
            Me.Controls.SetChildIndex(Me.radCheckSelectedButton, 0)
            Me.Controls.SetChildIndex(Me.radCheckedListBox1, 0)
            Me.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radListView2, 0)
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckedListBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radListView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radOrderButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radClearAllButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckAllButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckSelectedButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radListView2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private radCheckedListBox1 As Telerik.WinControls.UI.RadCheckedListBox
        Private radListView1 As Telerik.WinControls.UI.RadListView
        Private radOrderButton As Telerik.WinControls.UI.RadButton
        Private radClearAllButton As Telerik.WinControls.UI.RadButton
        Private radCheckAllButton As Telerik.WinControls.UI.RadButton
        Private radCheckSelectedButton As Telerik.WinControls.UI.RadButton
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radListView2 As Telerik.WinControls.UI.RadListView
    End Class
End Namespace
