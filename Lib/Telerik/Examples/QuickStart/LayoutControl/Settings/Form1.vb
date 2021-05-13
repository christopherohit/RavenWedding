Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.LayoutControl.Settings
    Partial Public Class Form1
        Inherits ExamplesForm
        Private lastTeamMemberItem As LayoutControlItem
        Private lastTeamMemberNumber As Integer = 4

        Public Sub New()
            InitializeComponent()
            lastTeamMemberItem = Me.layoutControlItem6
        End Sub

        Private Sub radButtonAddMember_Click(sender As Object, e As EventArgs) Handles radButtonAddMember.Click
            Dim newTeamMemberItem As New LayoutControlItem()
            newTeamMemberItem.AssociatedControl = New RadTextBoxControl() With { _
                .ThemeName = Me.radLayoutControl1.ThemeName _
            }

            newTeamMemberItem.DrawText = True
            newTeamMemberItem.Image = My.Resources.user
            newTeamMemberItem.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
            newTeamMemberItem.ImageLayout = System.Windows.Forms.ImageLayout.None
            newTeamMemberItem.MaxSize = New System.Drawing.Size(0, 52)
            newTeamMemberItem.MinSize = New System.Drawing.Size(46, 52)
            newTeamMemberItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            newTeamMemberItem.TextFixedSize = 26
            newTeamMemberItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            newTeamMemberItem.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top
            newTeamMemberItem.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed

            newTeamMemberItem.Text = [String].Format("Team Member {0}", System.Threading.Interlocked.Increment(lastTeamMemberNumber))

            Me.radLayoutControl1.AddItem(newTeamMemberItem, lastTeamMemberItem, LayoutControlDropPosition.Bottom)
            Me.lastTeamMemberItem = newTeamMemberItem
        End Sub

        Private Sub radButtonCustomize_Click(sender As Object, e As EventArgs) Handles radButtonEditLayout.Click
            Me.radLayoutControl1.ShowCustomizeDialog()
        End Sub

        Private Sub radButtonSaveLayout_Click(sender As Object, e As EventArgs) Handles radButtonSaveLayout.Click
            OnSaveLayoutButtonClick()
        End Sub

        Private Sub radButtonLoadLayout_Click(sender As Object, e As EventArgs) Handles radButtonLoadLayout.Click
            OnLoadLayoutButtonClick()
        End Sub

        Protected Overridable Sub OnSaveLayoutButtonClick()
            Using sfd As New SaveFileDialog()
                sfd.DefaultExt = ".xml"
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
                If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.radLayoutControl1.SaveLayout(sfd.FileName)
                End If
            End Using
        End Sub

        Protected Overridable Sub OnLoadLayoutButtonClick()
            Using ofd As New OpenFileDialog()
                ofd.DefaultExt = ".xml"
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
                If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.radLayoutControl1.LoadLayout(ofd.FileName)
                End If
            End Using
        End Sub

    End Class
End Namespace
