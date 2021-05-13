Namespace Telerik.Examples.WinControls.Sparkline.Gallery
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim tableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim tableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim tableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim tableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.gridLineSpark = New Telerik.WinControls.UI.RadGridView()
            Me.gridAreaSpark = New Telerik.WinControls.UI.RadGridView()
            Me.gridBarSpark = New Telerik.WinControls.UI.RadGridView()
            Me.gridWinLossSpark = New Telerik.WinControls.UI.RadGridView()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLineSpark), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLineSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridAreaSpark), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridAreaSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridBarSpark), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridBarSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridWinLossSpark), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridWinLossSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.gridWinLossSpark)
            Me.radPanelDemoHolder.Controls.Add(Me.gridBarSpark)
            Me.radPanelDemoHolder.Controls.Add(Me.gridAreaSpark)
            Me.radPanelDemoHolder.Controls.Add(Me.gridLineSpark)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(136, 172)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1300, 470)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(230, 170)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 170)
            Me.gridLineSpark.AllowRowResize = False
            Me.gridLineSpark.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.gridLineSpark.Location = New System.Drawing.Point(0, 0)
            Me.gridLineSpark.MasterTemplate.ViewDefinition = tableViewDefinition8
            Me.gridLineSpark.Name = "radGridView1"
            Me.gridLineSpark.Size = New System.Drawing.Size(1300, 110)
            Me.gridLineSpark.TabIndex = 0
            Me.gridAreaSpark.AllowRowResize = False
            Me.gridAreaSpark.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.gridAreaSpark.Location = New System.Drawing.Point(0, 120)
            Me.gridAreaSpark.MasterTemplate.ViewDefinition = tableViewDefinition7
            Me.gridAreaSpark.Name = "radGridView2"
            Me.gridAreaSpark.Size = New System.Drawing.Size(1300, 110)
            Me.gridAreaSpark.TabIndex = 1
            Me.gridBarSpark.AllowRowResize = False
            Me.gridBarSpark.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.gridBarSpark.Location = New System.Drawing.Point(0, 240)
            Me.gridBarSpark.MasterTemplate.ViewDefinition = tableViewDefinition6
            Me.gridBarSpark.Name = "radGridView3"
            Me.gridBarSpark.Size = New System.Drawing.Size(1300, 110)
            Me.gridBarSpark.TabIndex = 2
            Me.gridWinLossSpark.AllowRowResize = False
            Me.gridWinLossSpark.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.gridWinLossSpark.Location = New System.Drawing.Point(0, 360)
            Me.gridWinLossSpark.MasterTemplate.ViewDefinition = tableViewDefinition5
            Me.gridWinLossSpark.Name = "radGridView4"
            Me.gridWinLossSpark.Size = New System.Drawing.Size(1300, 110)
            Me.gridWinLossSpark.TabIndex = 3
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1045, 916)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLineSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLineSpark), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridAreaSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridAreaSpark), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridBarSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridBarSpark), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridWinLossSpark.MasterTemplate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridWinLossSpark), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private gridWinLossSpark As Telerik.WinControls.UI.RadGridView
        Private gridBarSpark As Telerik.WinControls.UI.RadGridView
        Private gridAreaSpark As Telerik.WinControls.UI.RadGridView
        Private gridLineSpark As Telerik.WinControls.UI.RadGridView
    End Class
End Namespace
