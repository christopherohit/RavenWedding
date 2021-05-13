Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.Fixed.Legacy
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
	<ToolboxItem(True)>
	Public Class PersonInfoControl
		Inherits RadControl
		Private personInfoElement As PersonInfoElement

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			Me.personInfoElement = New PersonInfoElement()
			parent.Children.Add(Me.personInfoElement)
		End Sub
		Protected Overrides Sub OnThemeChanged()
			MyBase.OnThemeChanged()
			If TelerikHelper.IsDarkTheme(Me.ThemeName) Then
				personInfoElement.NameElement.ForeColor = Color.White
				personInfoElement.EmailElement.ForeColor = Color.White
				personInfoElement.PhoneElement.ForeColor = Color.White
			Else
				personInfoElement.NameElement.ForeColor = Color.Black
				personInfoElement.EmailElement.ForeColor = Color.Black
				personInfoElement.PhoneElement.ForeColor = Color.Black
			End If
		End Sub
        Protected Overrides ReadOnly Property DefaultSize() As System.Drawing.Size
            Get
                Return RadControl.GetDpiScaledSize(New System.Drawing.Size(300, 130))
            End Get
        End Property

        Public Property PersonName() As String
			Get
				Return Me.personInfoElement.NameElement.Text
			End Get
			Set(ByVal value As String)
				Me.personInfoElement.NameElement.Text = value
			End Set
		End Property

		Public Property PersonEmail() As String
			Get
				Return Me.personInfoElement.EmailElement.Text
			End Get
			Set(ByVal value As String)
				Me.personInfoElement.EmailElement.Text = value
			End Set
		End Property

		Public Property PersonPhone() As String
			Get
				Return Me.personInfoElement.PhoneElement.Text
			End Get
			Set(ByVal value As String)
				Me.personInfoElement.PhoneElement.Text = value
			End Set
		End Property

		Public Property PersonImage() As Image
			Get
				Return Me.personInfoElement.ImageElement.Image
			End Get
			Set(ByVal value As Image)
				Me.personInfoElement.ImageElement.Image = value
			End Set
		End Property
	End Class
End Namespace
