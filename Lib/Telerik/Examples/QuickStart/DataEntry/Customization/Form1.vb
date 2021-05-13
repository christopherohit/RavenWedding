Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataEntry.Customization
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.radDataEntry1
            AddHandler Me.radDataEntry1.EditorInitializing, New EditorInitializingEventHandler(AddressOf radDataEntry1_EditorInitializing)
            AddHandler Me.radDataEntry1.ItemInitialized, New ItemInitializedEventHandler(AddressOf radDataEntry1_ItemInitialized)
            AddHandler Me.radDataEntry1.BindingCreated, New BindingCreatedEventHandler(AddressOf radDataEntry1_BindingCreated)
            Me.radDataEntry1.DataSource = New Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500)
        End Sub

        Private Sub radDataEntry1_BindingCreated(ByVal sender As Object, ByVal e As BindingCreatedEventArgs)
            If e.DataMember = "Salary" Then
                AddHandler e.Binding.Parse, New ConvertEventHandler(AddressOf Binding_Parse)
            End If
        End Sub

        Private Sub radDataEntry1_ItemInitialized(ByVal sender As Object, ByVal e As ItemInitializedEventArgs)
            Dim scaleFactor As SizeF = Me.radDataEntry1.RootElement.DpiScaleFactor
            Dim descaleFactor As SizeF = New SizeF(1 / scaleFactor.Width, 1 / scaleFactor.Height)

            If e.Panel.Controls(1).Text = "First Name" Then
                e.Panel.Size = New Size(TelerikDpiHelper.ScaleInt(300, scaleFactor), TelerikDpiHelper.ScaleInt(Me.radDataEntry1.ItemDefaultSize.Height, descaleFactor))
                e.Panel.Controls(1).Text = "Name"
            ElseIf e.Panel.Controls(1).Text = "Last Name" Then
                e.Panel.Size = New Size(TelerikDpiHelper.ScaleInt(160, scaleFactor), TelerikDpiHelper.ScaleInt(Me.radDataEntry1.ItemDefaultSize.Height, descaleFactor))
                e.Panel.Controls(1).Visible = False
                e.Panel.Location = TelerikDpiHelper.ScalePoint(New Point(310, 10), scaleFactor)
            Else
                e.Panel.Location = New Point(e.Panel.Location.X, e.Panel.Location.Y - TelerikDpiHelper.ScaleInt(35, scaleFactor))
            End If

            If TypeOf e.Panel.Controls(0) Is RadDateTimePicker Then
                e.Panel.Controls(0).ForeColor = Color.MediumVioletRed
            End If

            If e.Panel.Controls(1).Text = "Note" Then
                e.Panel.Size = New Size(e.Panel.Size.Width, TelerikDpiHelper.ScaleInt(100, scaleFactor))
                TryCast(e.Panel.Controls(0), RadTextBox).Multiline = True
            End If

            e.Panel.Controls(1).Font = New Font(e.Panel.Controls(1).Font.Name, 12.0F, FontStyle.Bold)
            e.Panel.Controls(1).ForeColor = Color.Red
        End Sub

        Private Sub radDataEntry1_EditorInitializing(ByVal sender As Object, ByVal e As EditorInitializingEventArgs)
            If e.[Property].Name = "Salary" Then
                Dim radMaskedEditBox As RadMaskedEditBox = New RadMaskedEditBox()
                radMaskedEditBox.MaskType = MaskType.Numeric
                radMaskedEditBox.MaskedEditBoxElement.StretchVertically = True
                e.Editor = radMaskedEditBox
            End If

            If e.[Property].Name = "Password" Then
                TryCast(e.Editor, RadTextBox).PasswordChar = "*"c
            End If
        End Sub

        Private Sub Binding_Parse(ByVal sender As Object, ByVal e As ConvertEventArgs)
            Dim salary As Integer = Integer.Parse(e.Value.ToString(), NumberStyles.Currency)
            e.Value = salary
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If Me.IsTouchTheme() Then
                Dim newItemSize As Size = New Size(460, 32)

                If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                    newItemSize.Height = 36
                End If

                Me.radDataEntry1.ItemDefaultSize = newItemSize
                Me.radDataEntry1.Size = TelerikDpiHelper.ScaleSize(New Size(489, 464), Me.radDataEntry1.RootElement.DpiScaleFactor)
                Me.SuspendLayout()
                Me.radDataEntry1.DataSource = Nothing
                Me.radDataEntry1.DataSource = New Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500)
                Me.ResumeLayout()
            End If
        End Sub

        Private Function IsTouchTheme() As Boolean
            Return TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) OrElse Me.CurrentThemeName = "TelerikMetroTouch"
        End Function
    End Class
End Namespace
