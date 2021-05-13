Namespace Telerik.Examples.WinControls.Integration.BubbleBar
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.bubbleBar1 = New Telerik.Examples.WinControls.Integration.BubbleBar.BubbleBar()
			Me.radButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(709, 1)
			Me.settingsPanel.Size = New Size(200, 724)
			' 
			' bubbleBar1
			' 
            Me.bubbleBar1.Anchor = AnchorStyles.Top
			Me.bubbleBar1.BackColor = Color.Transparent
			Me.bubbleBar1.Element.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.bubbleBar1.Element.SerializeProperties = True
			Me.bubbleBar1.ForeColor = Color.Black
			Me.bubbleBar1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement7, Me.radButtonElement1, Me.radButtonElement2, Me.radButtonElement3, Me.radButtonElement4, Me.radButtonElement5, Me.radButtonElement6})
			Me.bubbleBar1.Location = New Point(219, 310)
			Me.bubbleBar1.Name = "bubbleBar1"
			' 
			' 
			' 
			Me.bubbleBar1.RootElement.ForeColor = Color.Black
			Me.bubbleBar1.RootElement.ToolTipText = Nothing
			Me.bubbleBar1.Size = New Size(472, 107)
			Me.bubbleBar1.TabIndex = 0
			Me.bubbleBar1.Text = "bubbleBar1"
			CType(Me.bubbleBar1.GetChildAt(0), Telerik.Examples.WinControls.Integration.BubbleBar.BubbleBarElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(246))))), (CInt(Fix((CByte(255))))))
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3F
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.1F
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(226))))), (CInt(Fix((CByte(255))))))
			CType(Me.bubbleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.FromArgb((CInt(Fix((CByte(162))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(254))))))
			' 
			' radButtonElement7
			' 
			Me.radButtonElement7.CanFocus = True
			Me.radButtonElement7.Image = (CType(resources.GetObject("radButtonElement7.Image"), Image))
			Me.radButtonElement7.Name = "radButtonElement7"
			Me.radButtonElement7.Padding = New Padding(2, 2, 2, 8)
			Me.radButtonElement7.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement7.ShowBorder = False
			Me.radButtonElement7.ToolTipText = Nothing
			CType(Me.radButtonElement7.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Image = (CType(resources.GetObject("radButtonElement1.Image"), Image))
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.Padding = New Padding(2, 2, 2, 8)
			Me.radButtonElement1.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement1.ShowBorder = False
			Me.radButtonElement1.ToolTipText = Nothing
			CType(Me.radButtonElement1.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement2
			' 
			Me.radButtonElement2.CanFocus = True
			Me.radButtonElement2.Image = (CType(resources.GetObject("radButtonElement2.Image"), Image))
			Me.radButtonElement2.Name = "radButtonElement2"
			Me.radButtonElement2.Padding = New Padding(2, 2, 8, 8)
			Me.radButtonElement2.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement2.ShowBorder = False
			Me.radButtonElement2.ToolTipText = Nothing
			CType(Me.radButtonElement2.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement3
			' 
			Me.radButtonElement3.CanFocus = True
			Me.radButtonElement3.Image = (CType(resources.GetObject("radButtonElement3.Image"), Image))
			Me.radButtonElement3.Name = "radButtonElement3"
			Me.radButtonElement3.Padding = New Padding(2, 2, 2, 8)
			Me.radButtonElement3.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement3.ShowBorder = False
			Me.radButtonElement3.ToolTipText = Nothing
			CType(Me.radButtonElement3.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement4
			' 
			Me.radButtonElement4.CanFocus = True
			Me.radButtonElement4.Image = (CType(resources.GetObject("radButtonElement4.Image"), Image))
			Me.radButtonElement4.Name = "radButtonElement4"
			Me.radButtonElement4.Padding = New Padding(2, 2, 2, 8)
			Me.radButtonElement4.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement4.ShowBorder = False
			Me.radButtonElement4.ToolTipText = Nothing
			CType(Me.radButtonElement4.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement5
			' 
			Me.radButtonElement5.CanFocus = True
			Me.radButtonElement5.Image = (CType(resources.GetObject("radButtonElement5.Image"), Image))
			Me.radButtonElement5.Name = "radButtonElement5"
			Me.radButtonElement5.Padding = New Padding(2, 2, 2, 8)
			Me.radButtonElement5.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement5.ShowBorder = False
			Me.radButtonElement5.ToolTipText = Nothing
			CType(Me.radButtonElement5.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButtonElement6
			' 
			Me.radButtonElement6.CanFocus = True
			Me.radButtonElement6.Image = (CType(resources.GetObject("radButtonElement6.Image"), Image))
			Me.radButtonElement6.Name = "radButtonElement6"
			Me.radButtonElement6.Padding = New Padding(2, 2, 2, 8)
			Me.radButtonElement6.ScaleTransform = New SizeF(0.65F, 0.65F)
			Me.radButtonElement6.ShowBorder = False
			Me.radButtonElement6.ToolTipText = Nothing
			CType(Me.radButtonElement6.GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' Form1
			' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.bubbleBar1)
			Me.Name = "Form1"
			Me.Size = New Size(910, 726)
			Me.Controls.SetChildIndex(Me.bubbleBar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private bubbleBar1 As BubbleBar
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement2 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement3 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement4 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement5 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement6 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement7 As Telerik.WinControls.UI.RadButtonElement
	End Class
End Namespace
