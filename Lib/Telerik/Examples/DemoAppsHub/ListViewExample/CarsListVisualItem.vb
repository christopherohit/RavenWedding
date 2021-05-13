Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports System.Drawing
Imports System.Windows.Forms

Namespace DemoAppsHub.ListViewExample
	Public Class CarsListVisualItem
		Inherits SimpleListViewVisualItem
		Private element1 As LightVisualElement
		Private element2 As LightVisualElement
		Private element3 As LightVisualElement
		Private element4 As LightVisualElement
        Private stackLayout As StackLayoutPanel

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.stackLayout = New StackLayoutPanel()
            Me.stackLayout.EqualChildrenWidth = True
            Me.stackLayout.Margin = New Padding(180, 30, 0, 0)

            Me.element1 = New LightVisualElement()
            element1.TextAlignment = ContentAlignment.MiddleLeft
            element1.MinSize = New Size(170, 0)
            element1.NotifyParentOnMouseInput = True
            element1.ShouldHandleMouseInput = False
            Me.stackLayout.Children.Add(Me.element1)

            Me.element2 = New LightVisualElement()
            element2.TextAlignment = ContentAlignment.MiddleLeft
            element2.MinSize = New Size(170, 0)
            element2.NotifyParentOnMouseInput = True
            element2.ShouldHandleMouseInput = False
            Me.stackLayout.Children.Add(Me.element2)

            Me.element3 = New LightVisualElement()
            element3.TextAlignment = ContentAlignment.MiddleLeft
            element3.MinSize = New Size(170, 0)
            element3.NotifyParentOnMouseInput = True
            element3.ShouldHandleMouseInput = False
            Me.stackLayout.Children.Add(Me.element3)

            Me.element4 = New LightVisualElement()
            element4.TextAlignment = ContentAlignment.MiddleLeft
            element4.MinSize = New Size(170, 0)
            element4.NotifyParentOnMouseInput = True
            element4.ShouldHandleMouseInput = False
            Me.stackLayout.Children.Add(Me.element4)

            Me.Children.Add(Me.stackLayout)
        End Sub

		Private Function ContainsFeature(ByVal item As ListViewDataItem, ByVal feature As String) As Boolean
			Return Not item(feature) Is Nothing AndAlso Convert.ToInt32(item(feature)) <> 0
		End Function

		Protected Overrides Sub SynchronizeProperties()
			MyBase.SynchronizeProperties()

			Me.Text = "<html><span style=""color:#141718;font-size:14.5pt;"">" & String.Format("{0}", Me.Data("Make")) & " " & String.Format("{0}", Me.Data("Model")) & "</span>"

            Me.element1.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & _
                "Manufactured:<span style=""color:#13224D;font-family:Segoe UI;"">" & String.Format("{0}", Me.Data("CarYear")) & "</span>" & _
                "<br>Category:<span style=""color:#13224D;font-family:Segoe UI;"">" & String.Format("{0}", Me.Data("CategoryName")) & "</span></span>"

			If Me.ContainsFeature(Me.Data, "ABS") Then
				If Me.ContainsFeature(Me.Data, "ESR") Then
					Me.element2.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "ABS:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "<br>ESR:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "</span>"
				Else
					Me.element2.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "ABS:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "<br>ESR:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "</span>"
				End If
			Else
				If Me.ContainsFeature(Me.Data, "ESR") Then
					Me.element2.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "ABS:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "<br>ESR:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "</span>"
				Else
					Me.element2.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "ABS:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "<br>ESR:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "</span>"
				End If
			End If

			If Me.ContainsFeature(Me.Data, "Mp3Player") Then
				If Me.ContainsFeature(Me.Data, "DVDPlayer") Then
					Me.element3.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "MP3 Player:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "<br>DVD Player:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "</span>"
				Else
					Me.element3.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "MP3 Player:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "<br>DVD Player:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "</span>"
				End If
			Else
				If Me.ContainsFeature(Me.Data, "DVDPlayer") Then
					Me.element3.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "MP3 Player:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "<br>DVD Player:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "</span>"
				Else
					Me.element3.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "MP3 Player:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "<br>DVD Player:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "</span>"
				End If
			End If

			If Me.ContainsFeature(Me.Data, "AirConditioner") Then
				If Me.ContainsFeature(Me.Data, "Navigation") Then
					Me.element4.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "Air Conditioner:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "<br>Navigation:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "</span>"
				Else
					Me.element4.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "Air Conditioner:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "<br>Navigation:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "</span>"
				End If
			Else
				If Me.ContainsFeature(Me.Data, "Navigation") Then
					Me.element4.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "Air Conditioner:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "<br>Navigation:" & ("<span style=""color:#13224D;font-family:Segoe UI;"">YES") & "</span>" & "</span>"
				Else
					Me.element4.Text = "<html><span style=""color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;"">" & "Air Conditioner:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "<br>Navigation:" & ("<span style=""color:#D71B0E;"">NO") & "</span>" & "</span>"
				End If
			End If

			Me.TextAlignment = ContentAlignment.TopLeft
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(SimpleListViewVisualItem)
			End Get
		End Property
	End Class
End Namespace
