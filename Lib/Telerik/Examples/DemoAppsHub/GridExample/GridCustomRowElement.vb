Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Namespace DemoAppsHub.GridExample
	Public Class GridCustomRowElement
		Inherits GridDataRowElement
		Private Shared contentFont As Font = New Font("Segoe UI", 9f, FontStyle.Regular)

		Private detailsContent As LightVisualElement

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridDataRowElement)
			End Get
		End Property

		Public Overrides Sub Attach(ByVal row As GridViewRowInfo, ByVal context As Object)
			MyBase.Attach(row, context)

			Dim firstName As String = row.Cells("FirstName").Value.ToString()
			Dim lastName As String = row.Cells("LastName").Value.ToString()
			Dim title As String = row.Cells("Title").Value.ToString()
			Dim country As String = row.Cells("Country").Value.ToString()
			Dim description As String = row.Cells("Notes").Value.ToString()

			detailsContent.Text = String.Format("<html><b>{0},{1}</b> - <i>{2},{3}</i><br><br>{4}", lastName, firstName, title, country, description)
			'detailsContent.ClipText = true;
			'detailsContent.ClipDrawing = true;

			'this.ClipDrawing = true;

			Dim bytes As Byte() = CType(row.Cells("Photo").Value, Byte())
			detailsContent.Image = GetImageFromBytes(bytes)
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			detailsContent = New LightVisualElement()
			detailsContent.TextAlignment = ContentAlignment.MiddleLeft
			detailsContent.TextImageRelation = TextImageRelation.ImageBeforeText
			detailsContent.ImageAlignment = ContentAlignment.MiddleLeft
			detailsContent.Padding = New Padding(10)
			detailsContent.ImageLayout = ImageLayout.Zoom
			detailsContent.TextWrap = True
			detailsContent.DisableHTMLRendering = False
			detailsContent.Font = contentFont
			Me.Children.Add(detailsContent)
		End Sub

		Protected Overrides Overloads Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			If availableSize.Height > 60 Then
				Me.Children(1).Visibility = Telerik.WinControls.ElementVisibility.Hidden
				detailsContent.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Else
				Me.Children(1).Visibility = Telerik.WinControls.ElementVisibility.Visible
				detailsContent.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
			Dim desiredSize As SizeF = MyBase.MeasureOverride(availableSize)

			detailsContent.Measure(New SizeF(availableSize.Width - 100, availableSize.Height - 10))

			Return desiredSize
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			If detailsContent.Visibility = Telerik.WinControls.ElementVisibility.Visible Then
				detailsContent.Arrange(New RectangleF(50, 5, Math.Min(detailsContent.DesiredSize.Width, finalSize.Width - 100), Math.Min(detailsContent.DesiredSize.Height, finalSize.Height - 10)))
			Else
				MyBase.ArrangeOverride(finalSize)
			End If

			Return finalSize
		End Function

		Private Const OleHeaderSize As Integer = 78

		Private Function GetImageFromBytes(ByVal bytes As Byte()) As Image
			If bytes Is Nothing OrElse bytes.Length = 0 Then
				Return Nothing
			End If
			Dim result As Image = Nothing
			Dim stream As MemoryStream = Nothing
			Try
				Dim count As Integer
				Dim start As Integer

				If IsOleContainer(bytes) Then
					count = bytes.Length - OleHeaderSize
					start = OleHeaderSize
				Else
					count = bytes.Length
					start = 0
				End If
				stream = New MemoryStream(bytes, start, count)
				result = Image.FromStream(stream)
			Catch
				result = Nothing
			Finally
				If Not stream Is Nothing Then
					stream.Close()
				End If
			End Try
			Return result
		End Function

		Private Function IsOleContainer(ByVal imageData As Byte()) As Boolean
			Return (Not imageData Is Nothing AndAlso imageData(0) = &H15 AndAlso imageData(1) = &H1C)
		End Function
	End Class
End Namespace
