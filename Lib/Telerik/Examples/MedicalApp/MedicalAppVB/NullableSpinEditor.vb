Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Windows.Forms

Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace MedicalAppCS
	Public Class NullableSpinEditor
		Inherits RadSpinEditor
		Public Event NullableValueChanged As EventHandler

		Public Property NullableValue() As Nullable(Of Decimal)
			Get
				Return (TryCast(Me.SpinElement, NullableSpinEditorElement)).NullableValue
			End Get
			Set
                TryCast(Me.SpinElement, NullableSpinEditorElement).NullableValue = Value
			End Set
		End Property

		Public Sub New()
			Me.AutoSize = True
			Me.TabStop = False
			MyBase.SetStyle(ControlStyles.Selectable, True)
		End Sub

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			Dim baseType As Type = GetType(RadSpinEditor)
			Dim element As NullableSpinEditorElement = New NullableSpinEditorElement()
			element.RightToLeft = Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
			Me.RootElement.Children.Add(element)

			AddHandler element.ValueChanging, AddressOf spinElement_ValueChanging
			AddHandler element.ValueChanged, AddressOf spinElement_ValueChanged
			AddHandler element.TextChanging, AddressOf spinElement_TextChanging
			AddHandler element.NullableValueChanged, AddressOf element_NullableValueChanged

			AddHandler element.KeyDown, AddressOf OnSpinElementKeyDown
			AddHandler element.KeyPress, AddressOf OnSpinElementKeyPress
			AddHandler element.KeyUp, AddressOf OnSpinElementKeyUp

			baseType.GetField("spinElement", BindingFlags.Instance Or BindingFlags.NonPublic).SetValue(Me, element)
		End Sub

		Private Sub element_NullableValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.NullableValueChangedEvent Is Nothing Then
				RaiseEvent NullableValueChanged(Me, EventArgs.Empty)
			End If
		End Sub

		Private cache As Dictionary(Of String, MethodInfo) = New Dictionary(Of String, MethodInfo)()
		Private Sub InvokeBaseMethod(ByVal name As String, ParamArray ByVal parameters As Object())
			If (Not cache.ContainsKey(name)) Then
				cache(name) = GetType(RadSpinEditor).GetMethod(name, BindingFlags.Instance Or BindingFlags.NonPublic)
			End If

			cache(name).Invoke(Me, parameters)
		End Sub

		Private Sub OnSpinElementKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			Me.InvokeBaseMethod("OnSpinElementKeyUp", sender, e)
		End Sub

		Private Sub OnSpinElementKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			Me.InvokeBaseMethod("OnSpinElementKeyPress", sender, e)
		End Sub

		Private Sub OnSpinElementKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Me.InvokeBaseMethod("OnSpinElementKeyDown", sender, e)
		End Sub

		Private Sub spinElement_TextChanging(ByVal sender As Object, ByVal e As TextChangingEventArgs)
			Me.InvokeBaseMethod("spinElement_TextChanging", sender, e)
		End Sub

		Private Sub spinElement_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.InvokeBaseMethod("spinElement_ValueChanged", sender, e)
			Me.NullableValue = Me.Value
		End Sub

		Private Sub spinElement_ValueChanging(ByVal sender As Object, ByVal e As ValueChangingEventArgs)
			Me.InvokeBaseMethod("spinElement_ValueChanging", sender, e)
		End Sub

		Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
			If keyData = Keys.Tab Then
                TryCast(Me.SpinElement, NullableSpinEditorElement).CommitText()
			End If

			Return MyBase.ProcessCmdKey(msg, keyData)
		End Function

		Protected Overrides Sub OnLostFocus(ByVal e As EventArgs)
            TryCast(Me.SpinElement, NullableSpinEditorElement).CommitText()
			MyBase.OnLostFocus(e)
		End Sub

		Protected Overrides ReadOnly Property DefaultSize() As Size
			Get
				Return GetDpiScaledSize(New Size(100, 20))
			End Get
		End Property
	End Class

	Public Class NullableSpinEditorElement
		Inherits RadSpinElement
		Private nullableValue_Renamed As Nullable(Of Decimal)

		Public Property NullableValue() As Nullable(Of Decimal)
			Get
				Return Me.nullableValue_Renamed
			End Get
			Set
				Me.nullableValue_Renamed = Value
				If Value.HasValue Then
					Me.internalValue = Value.Value
				Else
					Me.internalValue = Me.MinValue
				End If

				Me.Validate()
				Me.OnNullableValueChanged()
			End Set
		End Property

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				Me.CommitText()
				e.Handled = True
				Return
			End If

			MyBase.OnKeyDown(e)
		End Sub

		Public Overridable Sub CommitText()
			If Me.TextBoxItem.Text = String.Empty Then
				Me.NullableValue = Nothing
			Else
				Me.NullableValue = Me.GetValueFromText()
			End If
		End Sub

		Public Overrides Function Validate() As Boolean
			If (Not Me.NullableValue.HasValue) Then
				Me.TextBoxItem.Text = String.Empty
				Return True
			End If
			If Me.ThousandsSeparator Then
				Me.TextBoxItem.Text = Me.internalValue.ToString(("N") + Me.DecimalPlaces.ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture)
			Else
				Me.TextBoxItem.Text = Me.internalValue.ToString(("F") + Me.DecimalPlaces.ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture)
			End If

			Return True
		End Function

		Public Overrides Sub PerformStep(ByVal [step] As Decimal)
			Dim value As Decimal = Me.GetValueFromText()

			Try
				Dim incValue As Decimal = value + [step]
				value = incValue
			Catch e1 As OverflowException
			End Try

			Me.NullableValue = Me.Constrain(value)
			Me.Validate()
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadSpinElement)
			End Get
		End Property

		Public Event NullableValueChanged As EventHandler

		Protected Overridable Sub OnNullableValueChanged()
			If Not Me.NullableValueChangedEvent Is Nothing Then
				RaiseEvent NullableValueChanged(Me, EventArgs.Empty)
			End If
		End Sub
	End Class
End Namespace
