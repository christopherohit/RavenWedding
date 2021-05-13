Namespace Telerik.Examples.WinControls.Editors
    Partial Public Class EditorExampleBaseForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(716, 1)
            Me.settingsPanel.Size = New Size(200, 598)
            ' 
            ' radPanelDemoHolder
            ' 
            Me.radPanelDemoHolder.Location = New Point(404, 285)
            Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
            Me.radPanelDemoHolder.Size = New Size(200, 100)
            Me.radPanelDemoHolder.TabIndex = 1
            ' 
            ' EditorExampleBaseForm
            ' 
            Me.Controls.Add(Me.radPanelDemoHolder)
            Me.Name = "EditorExampleBaseForm"
            Me.Size = New Size(1170, 671)
            Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Protected radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
    End Class
End Namespace