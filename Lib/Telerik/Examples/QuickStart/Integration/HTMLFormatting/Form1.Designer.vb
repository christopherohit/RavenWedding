Namespace Telerik.Examples.WinControls.Integration.HTMLFormatting
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Me.components = New System.ComponentModel.Container()
			Dim shadowSettings1 As New Telerik.WinControls.Paint.ShadowSettings()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			' 
			' radLabel1
			' 
			Me.radLabel1.AutoSize = False
			Me.radLabel1.Location = New Point(37, 23)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(182, 121)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "<html><size=12>This is RadLabel <br><b><font=Arial>Arial, Bold</b><br><i><font=Ti" & "mes New Roman>Times, Italic <u>Underline</u><br><size=9>Size = 9<br><color= 0, 0" & ", 255>Sample Text   " & vbCrLf
			CType(Me.radLabel1.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "<html><size=12>This is RadLabel <br><b><font=Arial>Arial, Bold</b><br><i><font=Ti" & "mes New Roman>Times, Italic <u>Underline</u><br><size=9>Size = 9<br><color= 0, 0" & ", 255>Sample Text   " & vbCrLf
			CType(Me.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextWrap = True
			CType(Me.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.TopLeft
			shadowSettings1.Depth = New Point(1, 1)
			shadowSettings1.ShadowColor = Color.Gainsboro
			CType(Me.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = shadowSettings1
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Location = New Point(257, 23)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(106, 17)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "<html><color=green>Sample  <b><i><u><font=Times New Roman><color=128,52,52,52>Che" & "ckbox"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Location = New Point(257, 46)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(145, 17)
			Me.radRadioButton1.TabIndex = 2
			Me.radRadioButton1.Text = "<html><color=purple>Sample  <b><i><u><color=52,52,52>RadRadioButton"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(257, 69)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(75, 23)
			Me.radButton1.TabIndex = 6
			Me.radButton1.Text = "<html><i><b><color=red>rad<u><color=green>Button"
			' 
			' radToggleButton1
			' 
			Me.radToggleButton1.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.radToggleButton1.Location = New Point(257, 98)
			Me.radToggleButton1.Name = "radToggleButton1"
			Me.radToggleButton1.Size = New Size(100, 23)
			Me.radToggleButton1.TabIndex = 8
			Me.radToggleButton1.Text = "<html>rad<b>Toggle</b>Button"
			' 
			' radListBox1
			' 
			Me.radListBox1.FormatString = "{0}"
			radListDataItem1.Text = "<html><b>radListBox<i><color=blue> Item"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "<html><i>radListBox</i><color=red> Item"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "<html><u><font=Arial>radListBox</u><b> Item"
			radListDataItem3.TextWrap = True
			radListDataItem4.Text = "<html><size=+1>radListBox</b><i> Item"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "<html><color=red>radListBox<color=128,255,0,0> Item"
			radListDataItem5.TextWrap = True
			radListDataItem6.Text = "<html><size=-3>radListBoxItem"
			radListDataItem6.TextWrap = True
			Me.radListBox1.Items.Add(radListDataItem1)
			Me.radListBox1.Items.Add(radListDataItem2)
			Me.radListBox1.Items.Add(radListDataItem3)
			Me.radListBox1.Items.Add(radListDataItem4)
			Me.radListBox1.Items.Add(radListDataItem5)
			Me.radListBox1.Items.Add(radListDataItem6)
			Me.radListBox1.Location = New Point(431, 23)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.Size = New Size(189, 98)
			Me.radListBox1.TabIndex = 7
			Me.radListBox1.Text = "<html><u><font=Arial>radListBox</u><b> Item"
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radCheckBox1)
			Me.radPanel1.Controls.Add(Me.radRadioButton1)
			Me.radPanel1.Controls.Add(Me.radListBox1)
			Me.radPanel1.Controls.Add(Me.radToggleButton1)
			Me.radPanel1.Controls.Add(Me.radLabel1)
			Me.radPanel1.Controls.Add(Me.radButton1)
			Me.radPanel1.ForeColor = Color.Black
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(644, 168)
			Me.radPanel1.TabIndex = 9
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(246))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3F
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.01F
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(255))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.FromArgb((CInt(Fix((CByte(162))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(254))))))
			' 
			' roundRectShape1
			' 
			Me.roundRectShape1.Radius = 10
			' 
			' radLabel2
			' 
			Me.radLabel2.AutoSize = False
			Me.radLabel2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radLabel2.ForeColor = Color.White
			Me.radLabel2.Location = New Point(4, 208)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(332, 37)
			Me.radLabel2.TabIndex = 10
			Me.radLabel2.Text = "HTML Like Formatting"
			Me.radLabel2.TextWrap = False
			' 
			' radTextBox1
			' 
			Me.radTextBox1.AutoSize = False
			Me.radTextBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radTextBox1.Location = New Point(0, 243)
			Me.radTextBox1.Multiline = True
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.Size = New Size(644, 91)
			Me.radTextBox1.TabIndex = 11
			Me.radTextBox1.TabStop = False
			' 
			' radButton2
			' 
			Me.radButton2.Location = New Point(447, 207)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(197, 30)
			Me.radButton2.TabIndex = 12
			Me.radButton2.Text = "Start RadMarkupEditor"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.radTextBox1)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.radButton2)
			Me.Name = "Form1"
			Me.Size = New Size(1308, 631)
			Me.Controls.SetChildIndex(Me.radButton2, 0)
			Me.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.Controls.SetChildIndex(Me.radTextBox1, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radListBox1 As Telerik.WinControls.UI.RadListControl
		Private radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private radButton2 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace