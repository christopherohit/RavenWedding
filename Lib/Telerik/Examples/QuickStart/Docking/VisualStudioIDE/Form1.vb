Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI.Docking
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes

Namespace Telerik.Examples.WinControls.Docking.VisualStudioIDE
	Partial Public Class Form1
		Inherits RadForm
		Private Shared ReadOnly RtfFolder As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docking\VisualStudioIDE\Files")
		Private Shared ReadOnly Form1RftFile As String = Path.Combine(RtfFolder, "Form1.rtf")
		Private Shared ReadOnly Form1DesignerRftFile As String = Path.Combine(RtfFolder, "Form1.Designer.rtf")
		Private Shared ReadOnly AssemblyInfoRftFile As String = Path.Combine(RtfFolder, "AssemblyInfo.rtf")
		Private Shared ReadOnly ProgramRtfFile As String = Path.Combine(RtfFolder, "Program.rtf")
		Private Shared ReadOnly OutputFile As String = Path.Combine(RtfFolder, "Output.txt")

		Private Const ErrorGridRow As Integer = 1
		Private Const ErrorGridLine As Integer = 20
		Private Const ErrorGridColumn As Integer = 33
		Private Const ErrorGridFile As String = "Program.cs"
		Private Const ErrorGridProject As String = "ProjectTracker"
		Private Const ErrorGridDescription As String = "The type or namespace name 'Form12' could not be found (are you missing a using directive or an assembly reference?)	C:\ProjectTracker\Program.cs"

		Private Const TaskGridDescription As String = "TO DO: Refactor the whole data access layer to use Open Access"
		Private Const TaskGridFile As String = "DBPool.cs"
		Private Const TaskGridLine As Integer = 501


		Public Sub New()
			InitializeComponent()
			Dim TempVisualStudio2012LightTheme As VisualStudio2012LightTheme = New VisualStudio2012LightTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "VisualStudio2012Light")
			Me.richTextBoxOutput.TextBoxElement.BackColor = Color.FromArgb(230, 231, 232)
			Me.radGridViewErrors.TableElement.BackColor = Color.FromArgb(230, 231, 232)
			Me.radGridViewTasks.TableElement.BackColor = Color.FromArgb(230, 231, 232)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.SetupAllGrids()
			Me.SetupToolWindowImages()
			Me.SetupTreeNodes()
			Me.richTextBoxOutput.Font = New Font("Consolas", 9, FontStyle.Regular)
			Me.richTextBoxOutput.Text = File.ReadAllText(OutputFile)
		End Sub

		Private Sub SetupTreeNodes()
			Me.radTreeView1.Find("Form1.cs").Tag = Form1RftFile
			Me.radTreeView1.Find("Program.cs").Tag = ProgramRtfFile
			Me.radTreeView1.Find("AssemblyInfo.cs").Tag = AssemblyInfoRftFile
			Me.radTreeView1.Find("Form1.Designer.cs").Tag = Form1DesignerRftFile
			OpenFile(Form1RftFile, "Form1.cs")
		End Sub

		Private Function OpenFile(ByVal fileName As String, ByVal displayName As String) As DocumentWindow
			Dim dw As New DocumentWindow()
			Dim rtb As New RichTextBox()
			rtb.Rtf = File.ReadAllText(fileName)
			rtb.Dock = DockStyle.Fill
			rtb.BorderStyle = BorderStyle.None
			rtb.AcceptsTab = True
			AddHandler rtb.TextChanged, AddressOf editor_TextChanged

			dw.Controls.Add(rtb)
			dw.Text = displayName
			dw.Name = displayName
			Me.radDock1.AddDocument(dw)

			Return dw
		End Function

		Private Sub SetupToolWindowImages()
			toolWindow5.Image = ImageList1.Images(1)
			toolWindow3.Image = ImageList1.Images(5)
			toolWindow4.Image = ImageList1.Images(14)
		End Sub

		Private Sub SetupAllGrids()
			Me.radGridViewErrors.Columns("columnImage").HeaderText = String.Empty
			Me.radGridViewErrors.Columns("columnNumber").HeaderText = String.Empty

			Me.radGridViewErrors.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Dim image As Image = ImageList1.Images(11)

			Me.radGridViewErrors.Rows.Add(image, ErrorGridRow, ErrorGridDescription, ErrorGridFile, ErrorGridLine, ErrorGridColumn, ErrorGridProject)
			Me.radGridViewErrors.MasterTemplate.ShowRowHeaderColumn = False

			Me.radGridViewTasks.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridViewTasks.Rows.Add(String.Empty, TaskGridDescription, TaskGridFile, TaskGridLine)
			Me.radGridViewTasks.MasterTemplate.ShowRowHeaderColumn = False
		End Sub

		Private Sub editor_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim senderRtb As RichTextBox = TryCast(sender, RichTextBox)
			Dim document As DocumentWindow = TryCast(senderRtb.Parent, DocumentWindow)

			If document IsNot Nothing Then
				If Not document.Text.EndsWith("*") Then
					document.Text &= "*"
				End If
                
                If document.TabStrip IsNot Nothing AndAlso Object.Equals(document.TabStrip.TabStripElement.PreviewItem, document.TabStripItem) Then
                    document.TabStrip.TabStripElement.PreviewItem = Nothing
                End If
			End If
		End Sub

		Private Sub radTreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs) Handles radTreeView1.SelectedNodeChanged
			Dim node As RadTreeNode = Me.radTreeView1.SelectedNode
			If node IsNot Nothing AndAlso node.Tag IsNot Nothing Then
				Dim document As DocumentWindow = Me.radDock1.GetWindow(Of DocumentWindow)(e.Node.Text)
				If document Is Nothing Then
					document = OpenFile(e.Node.Tag.ToString(), e.Node.Text)
				Else
					Return
				End If
                
                If Object.Equals(document.TabStrip.TabStripElement.PreviewItem, document.TabStripItem) Then
                    Return
                End If

				For Each dw As DocumentWindow In Me.radDock1.GetWindows(Of DocumentWindow)()
					Dim tabStrip As RadPageViewStripElement = dw.TabStrip.TabStripElement
					If tabStrip.PreviewItem IsNot Nothing Then
						Me.radDock1.CloseWindow(CType((CType(tabStrip.PreviewItem, TabStripItem)).TabPanel, DockWindow))
						tabStrip.PreviewItem = Nothing
					End If
				Next dw

				document.TabStrip.TabStripElement.PreviewItem = document.TabStripItem
				Me.radDock1.ActiveWindow = document
			End If
		End Sub

		Private Sub radTreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As RadTreeViewEventArgs) Handles radTreeView1.NodeMouseDoubleClick
			If e.Node.Tag IsNot Nothing Then
				Dim document As DocumentWindow = Me.radDock1.GetWindow(Of DocumentWindow)(e.Node.Text)
				If document Is Nothing Then
                    document = OpenFile(e.Node.Tag.ToString(), e.Node.Text)
                ElseIf Object.Equals(document.TabStrip.TabStripElement.PreviewItem, document.TabStripItem) Then
                    document.TabStrip.TabStripElement.PreviewItem = Nothing
				End If

				Me.radDock1.ActiveWindow = document
			ElseIf e.Node.Nodes.Count > 0 Then
				e.Node.Expanded = Not e.Node.Expanded
			End If
		End Sub

		Private Sub radTreeView1_NodeExpandedChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs) Handles radTreeView1.NodeExpandedChanged
			If e.Node.Text = "Forms" Then
				e.Node.ImageIndex = If(e.Node.Expanded, 4, 2)
				e.Node.Image = Nothing
			End If
		End Sub

	End Class
End Namespace
