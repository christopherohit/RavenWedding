Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes

Namespace Telerik.Examples.WinControls.Forms.MessageBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radComboButtons.SelectedIndex = 0
			Me.radComboMessageType.SelectedIndex = 0
			Me.radPanel1.PanelElement.PanelFill.Visibility = ElementVisibility.Collapsed
			Me.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim buttons As MessageBoxButtons = Me.RetrieveButtonsFromCombo()
			Dim icon As RadMessageIcon = Me.RetrieveIconFromCombo()
			Dim rtl As RightToLeft = RightToLeft.No

			If Me.radCheckRTL.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				rtl = RightToLeft.Yes
			End If

			Dim ds As DialogResult

			Telerik.WinControls.RadMessageBox.SetThemeName(Me.CurrentThemeName)
			Telerik.WinControls.RadMessageBox.Instance.MinimumSize = New Size(100, 100)
			ds = Telerik.WinControls.RadMessageBox.Show(Me, Me.radTxtMessage.Text, Me.radTxtCaption.Text, buttons, icon, MessageBoxDefaultButton.Button1, rtl)

			Me.radTxtDialogResult.Text = String.Format("{0}", ds)
		End Sub

		'private void radButton2_Click(object sender, EventArgs e)
		'{
		'    MessageBoxButtons buttons = this.RetrieveButtonsFromCombo();
		'    MessageBoxIcon icon = MessageBoxIcon.None;

		'    switch (this.radComboMessageType.SelectedIndex)
		'    {
		'        case 1:
		'            icon = MessageBoxIcon.Information;
		'            break;
		'        case 2:
		'            icon = MessageBoxIcon.Question;
		'            break;
		'        case 3:
		'            icon = MessageBoxIcon.Exclamation;
		'            break;
		'        case 4:
		'            icon = MessageBoxIcon.Error;
		'            break;
		'    }

		'    DialogResult ds;

		'    if (this.radCheckRTL.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
		'    {
		'        ds = MessageBox.Show(this, this.radTxtMessage.Text, this.radTxtCaption.Text,
		'            buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
		'    }
		'    else
		'    {
		'        ds = MessageBox.Show(this, this.radTxtMessage.Text, this.radTxtCaption.Text,
		'            buttons, icon);
		'    }

		'    this.radTxtDialogResult.Text = String.Format("{0}", ds);
		'}

		Private Function RetrieveButtonsFromCombo() As MessageBoxButtons
			Select Case Me.radComboButtons.SelectedIndex
				Case 1
					Return MessageBoxButtons.OKCancel
				Case 2
					Return MessageBoxButtons.YesNo
				Case 3
					Return MessageBoxButtons.YesNoCancel
				Case 4
					Return MessageBoxButtons.RetryCancel
				Case 5
					Return MessageBoxButtons.AbortRetryIgnore
			End Select

			Return MessageBoxButtons.OK
		End Function

		Private Function RetrieveIconFromCombo() As RadMessageIcon
			Select Case Me.radComboMessageType.SelectedIndex
				Case 1
					Return RadMessageIcon.Info
				Case 2
					Return RadMessageIcon.Question
				Case 3
					Return RadMessageIcon.Exclamation
				Case 4
					Return RadMessageIcon.Error
			End Select
			Return RadMessageIcon.None
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler radBtnShow.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace
