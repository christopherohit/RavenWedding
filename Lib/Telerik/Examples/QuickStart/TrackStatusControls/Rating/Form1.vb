
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TrackStatusControls.Rating
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()

            SetupSettings()
        End Sub

        Private Sub SetupSettings()

            Me.radRating1.SelectionMode = RatingSelectionMode.HalfItem
            Me.radRating2.SelectionMode = RatingSelectionMode.HalfItem
            Me.radRating3.SelectionMode = RatingSelectionMode.HalfItem
            Me.radRating4.SelectionMode = RatingSelectionMode.HalfItem

            Me.radRating1.AutoSize = True
            Me.radRating2.AutoSize = True
            Me.radRating3.AutoSize = True
            Me.radRating4.AutoSize = True

            EnumToListBox(GetType(RatingSelectionMode), Me.radDropDownList1)

            Me.radDropDownList1.SelectedIndex = 2

            Me.radSpinEditor1.Value = CInt(Me.radRating1.Minimum)
            Me.radSpinEditor2.Value = CInt(Me.radRating1.Maximum)

            If Me.radRating1.Direction = RatingDirection.Standard Then
                Me.radRadioButton1.IsChecked = True
            Else
                Me.radRadioButton2.IsChecked = True
            End If

            If Me.radRating1.RightToLeft = System.Windows.Forms.RightToLeft.Yes Then
                Me.radCheckBox1.IsChecked = True
            Else
                Me.radCheckBox1.IsChecked = False
            End If

            Me.radCheckBox2.IsChecked = Me.radRating1.[ReadOnly]
        End Sub

        Public Shared Sub EnumToListBox(EnumType As Type, TheListBox As RadDropDownList)
            Dim Values As Array = System.[Enum].GetValues(EnumType)

            For Each Value As Integer In Values
                Dim Display As String = [Enum].GetName(EnumType, Value)

                Dim Item As New RadListDataItem(Display, Value.ToString())

                TheListBox.Items.Add(Item)
            Next
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radRating1.SelectionMode = DirectCast(e.Position, RatingSelectionMode)
            Me.radRating2.SelectionMode = DirectCast(e.Position, RatingSelectionMode)
            Me.radRating3.SelectionMode = DirectCast(e.Position, RatingSelectionMode)
            Me.radRating4.SelectionMode = DirectCast(e.Position, RatingSelectionMode)
        End Sub

        Private Sub radSpinEditor1_ValueChanged(sender As Object, e As EventArgs)
            Me.radSpinEditor2.Minimum = Me.radSpinEditor1.Value + 1
            Me.radRating1.Minimum = CInt(Me.radSpinEditor1.Value)
            Me.radRating2.Minimum = CInt(Me.radSpinEditor1.Value)
            Me.radRating3.Minimum = CInt(Me.radSpinEditor1.Value)
            Me.radRating4.Minimum = CInt(Me.radSpinEditor1.Value)
        End Sub

        Private Sub radSpinEditor2_ValueChanged(sender As Object, e As EventArgs)
            Me.radSpinEditor1.Maximum = Me.radSpinEditor2.Value - 1
            Me.radRating1.Maximum = CInt(Me.radSpinEditor2.Value)
            Me.radRating2.Maximum = CInt(Me.radSpinEditor2.Value)
            Me.radRating3.Maximum = CInt(Me.radSpinEditor2.Value)
            Me.radRating4.Maximum = CInt(Me.radSpinEditor2.Value)
        End Sub

        Private Sub radRadioButton1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radRating1.Direction = RatingDirection.Standard
            Me.radRating2.Direction = RatingDirection.Standard
            Me.radRating3.Direction = RatingDirection.Standard
            Me.radRating4.Direction = RatingDirection.Standard
        End Sub

        Private Sub radRadioButton2_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radRating1.Direction = RatingDirection.Reversed
            Me.radRating2.Direction = RatingDirection.Reversed
            Me.radRating3.Direction = RatingDirection.Reversed
            Me.radRating4.Direction = RatingDirection.Reversed
        End Sub

        Private Sub radRadioButton3_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radRating1.Location = New System.Drawing.Point(50, 50)
            Me.radRating2.Location = New System.Drawing.Point(50, 120)
            Me.radRating3.Location = New System.Drawing.Point(250, 50)
            Me.radRating4.Location = New System.Drawing.Point(250, 120)
            Me.radRating1.Orientation = Orientation.Horizontal
            Me.radRating2.Orientation = Orientation.Horizontal
            Me.radRating3.Orientation = Orientation.Horizontal
            Me.radRating4.Orientation = Orientation.Horizontal
        End Sub

        Private Sub radRadioButton4_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radRating1.Location = New System.Drawing.Point(48, 49)
            Me.radRating2.Location = New System.Drawing.Point(48, 240)
            Me.radRating3.Location = New System.Drawing.Point(248, 49)
            Me.radRating4.Location = New System.Drawing.Point(254, 240)
            Me.radRating1.Orientation = Orientation.Vertical
            Me.radRating2.Orientation = Orientation.Vertical
            Me.radRating3.Orientation = Orientation.Vertical
            Me.radRating4.Orientation = Orientation.Vertical
        End Sub

        Private Sub radCheckBox1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If Me.radCheckBox1.IsChecked Then
                Me.radRating1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
                Me.radRating2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
                Me.radRating3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
                Me.radRating4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Else
                Me.radRating1.RightToLeft = System.Windows.Forms.RightToLeft.No
                Me.radRating2.RightToLeft = System.Windows.Forms.RightToLeft.No
                Me.radRating3.RightToLeft = System.Windows.Forms.RightToLeft.No
                Me.radRating4.RightToLeft = System.Windows.Forms.RightToLeft.No
            End If
        End Sub

        Private Sub radCheckBox2_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radRating1.[ReadOnly] = Me.radCheckBox2.IsChecked
            Me.radRating2.[ReadOnly] = Me.radCheckBox2.IsChecked
            Me.radRating3.[ReadOnly] = Me.radCheckBox2.IsChecked
            Me.radRating4.[ReadOnly] = Me.radCheckBox2.IsChecked
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radSpinEditor1.ValueChanged, AddressOf Me.radSpinEditor1_ValueChanged
            AddHandler Me.radSpinEditor2.ValueChanged, AddressOf Me.radSpinEditor2_ValueChanged
            AddHandler Me.radCheckBox2.ToggleStateChanged, AddressOf Me.radCheckBox2_ToggleStateChanged
            AddHandler Me.radRadioButton1.ToggleStateChanged, AddressOf Me.radRadioButton1_ToggleStateChanged
            AddHandler Me.radCheckBox1.ToggleStateChanged, AddressOf Me.radCheckBox1_ToggleStateChanged
            AddHandler Me.radRadioButton2.ToggleStateChanged, AddressOf Me.radRadioButton2_ToggleStateChanged
            AddHandler Me.radDropDownList1.SelectedIndexChanged, AddressOf Me.radDropDownList1_SelectedIndexChanged
            AddHandler Me.radRadioButton3.ToggleStateChanged, AddressOf radRadioButton3_ToggleStateChanged
            AddHandler Me.radRadioButton4.ToggleStateChanged, AddressOf radRadioButton4_ToggleStateChanged

        End Sub
    End Class
End Namespace