Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map
Imports Telerik.WinControls.UI.Map.Bing

Namespace Telerik.Examples.WinControls.Map.BingRoute
	Partial Public Class Form1
		Inherits ExamplesForm
		Private currentPositionPin As MapPin

		Public Sub New()
			InitializeComponent()

			Me.SetupOptions()
			Me.SetupProviders()
			Me.SetupLayer()
		End Sub

		Private Sub SetupOptions()
			Me.radDropDownListUnits.Items.Add(New RadListDataItem("Kilometers", DistanceUnit.Kilometer))
			Me.radDropDownListUnits.Items.Add(New RadListDataItem("Miles", DistanceUnit.Mile))

			Me.radDropDownListMode.Items.Add(New RadListDataItem("Driving", TravelMode.Driving))
			Me.radDropDownListMode.Items.Add(New RadListDataItem("Walking", TravelMode.Walking))

			Me.radDropDownListOptimize.Items.Add(New RadListDataItem("Time", RouteOptimization.Time))
			Me.radDropDownListOptimize.Items.Add(New RadListDataItem("Distance", RouteOptimization.Distance))
			Me.radDropDownListOptimize.Items.Add(New RadListDataItem("Time (avoid closures)", RouteOptimization.TimeAvoidClosure))
			Me.radDropDownListOptimize.Items.Add(New RadListDataItem("Time (acount for traffic)", RouteOptimization.TimeWithTraffic))

			Me.radDropDownListAvoid.Items.Add(New RadListDataItem("None", RouteAvoidance.None))
			Me.radDropDownListAvoid.Items.Add(New RadListDataItem("Highways", RouteAvoidance.Highways))
			Me.radDropDownListAvoid.Items.Add(New RadListDataItem("Tolls", RouteAvoidance.Tolls))
			Me.radDropDownListAvoid.Items.Add(New RadListDataItem("Minimize Highways", RouteAvoidance.MinimizeHighways))
			Me.radDropDownListAvoid.Items.Add(New RadListDataItem("Minimize Tolls", RouteAvoidance.MinimizeTolls))

			Me.radDropDownListAvoid.SelectedIndex = 0
			Me.radDropDownListOptimize.SelectedIndex = Me.radDropDownListAvoid.SelectedIndex
			Me.radDropDownListMode.SelectedIndex = Me.radDropDownListOptimize.SelectedIndex
			Me.radDropDownListUnits.SelectedIndex = Me.radDropDownListMode.SelectedIndex
		End Sub

		Private Sub SetupProviders()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.Culture = System.Threading.Thread.CurrentThread.CurrentCulture
			bingProvider.UseSession = True
			bingProvider.BingKey = My.Resources.BingKey
			AddHandler bingProvider.InitializationComplete, Sub()
				Dim request As New RouteRequest()
				request.DistanceUnit = DistanceUnit.Kilometer
				request.Options.Mode = TravelMode.Driving
				request.Options.Optimization = RouteOptimization.Time
				request.Options.RouteAttributes = RouteAttributes.RoutePath
				request.Options.RouteAvoidance = RouteAvoidance.None
				Me.radTextBoxStartPoint.Text = "Los Angelis, USA"
				Me.radTextBoxEndPoint.Text= "San Francisco, USA"
				request.RoutePoints.Add(New Waypoint(Me.radTextBoxStartPoint.Text))
				request.RoutePoints.Add(New Waypoint(Me.radTextBoxEndPoint.Text))

				bingProvider.CalculateRouteAsync(request)
			End Sub

			Me.radMap1.MapElement.Providers.Add(bingProvider)

			AddHandler bingProvider.CalculateRouteCompleted, AddressOf BingProvider_CalculateRouteCompleted
			AddHandler bingProvider.CalculateRouteError, AddressOf BingProvider_CalculateRouteError
		End Sub

		Private Sub SetupLayer()
			Dim pinsLayer As New MapLayer("Route")
			Me.radMap1.Layers.Add(pinsLayer)
		End Sub

		Private Sub radButtonCalculateRoute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonCalculateRoute.Click
			If TelerikHelper.StringIsNullOrWhiteSpace(Me.radTextBoxStartPoint.Text) Then
				RadMessageBox.ThemeName = Me.CurrentThemeName
				RadMessageBox.Show("Please enter valid start point.")
				Me.radTextBoxStartPoint.Focus()

				Return
			End If

			If TelerikHelper.StringIsNullOrWhiteSpace(Me.radTextBoxEndPoint.Text) Then
				RadMessageBox.ThemeName = Me.CurrentThemeName
				RadMessageBox.Show("Please enter valid end point.")
				Me.radTextBoxEndPoint.Focus()

				Return
			End If

			Dim request As New RouteRequest()
			request.DistanceUnit = CType(Me.radDropDownListUnits.SelectedItem.Value, DistanceUnit)
			request.Options.Mode = CType(Me.radDropDownListMode.SelectedItem.Value, TravelMode)
			request.Options.RouteAttributes = RouteAttributes.RoutePath

			If request.Options.Mode = TravelMode.Driving Then
				request.Options.Optimization = CType(Me.radDropDownListOptimize.SelectedItem.Value, RouteOptimization)
				request.Options.RouteAvoidance = CType(Me.radDropDownListAvoid.SelectedItem.Value, RouteAvoidance)
			End If

			request.RoutePoints.Add(New Waypoint(Me.radTextBoxStartPoint.Text))
			request.RoutePoints.Add(New Waypoint(Me.radTextBoxEndPoint.Text))

			Dim routeProvider As IMapRouteProvider = TryCast(Me.radMap1.Providers(0), IMapRouteProvider)
			routeProvider.CalculateRouteAsync(request)
		End Sub

		Private Sub BingProvider_CalculateRouteCompleted(ByVal sender As Object, ByVal e As RoutingCompletedEventArgs)
			Dim points As New List(Of PointG)()

			For Each coordinatePair As Double() In e.Route.RoutePath.Line.Coordinates
				Dim point As New PointG(coordinatePair(0), coordinatePair(1))
				points.Add(point)
			Next coordinatePair

			Me.radMap1.Layers("Route").Clear()

			Dim boundingRectangle As New RectangleG(e.Route.BBox(2), e.Route.BBox(1), e.Route.BBox(0), e.Route.BBox(3))
			Dim routeElement As New MapRoute(points, boundingRectangle)
			routeElement.BorderColor = Color.FromArgb(11, 195, 197)
			routeElement.BorderWidth = 3
			Dim start As New MapPin(New PointG(e.Route.RouteLegs(0).ActualStart.Coordinates(0), e.Route.RouteLegs(0).ActualStart.Coordinates(1)))
			start.BackColor = Color.FromArgb(11, 195, 197)
			Dim [end] As New MapPin(New PointG(e.Route.RouteLegs(e.Route.RouteLegs.Length - 1).ActualEnd.Coordinates(0), e.Route.RouteLegs(e.Route.RouteLegs.Length - 1).ActualEnd.Coordinates(1)))
			[end].BackColor = Color.FromArgb(11, 195, 197)

			Me.currentPositionPin = New MapPin(start.Location)
			currentPositionPin.BackColor = Color.White
			currentPositionPin.BorderColor = Color.FromArgb(11, 195, 197)

			Me.radMap1.MapElement.Layers("Route").Add(routeElement)
			Me.radMap1.MapElement.Layers("Route").Add(start)
			Me.radMap1.MapElement.Layers("Route").Add([end])
			Me.radMap1.MapElement.Layers("Route").Add(currentPositionPin)

			Me.radListView1.DisplayMember = "Instruction.Text"
			Me.radListView1.ValueMember = "ManeuverPoint"
			Me.radListView1.DataSource = e.Route.RouteLegs(0).ItineraryItems

			Me.radMap1.BringIntoView(boundingRectangle)
			Me.radMap1.Zoom(Me.radMap1.MapElement.ZoomLevel - 1)
			Me.radSplitContainer1.SplitPanels(1).Collapsed = False
		End Sub

		Private Sub BingProvider_CalculateRouteError(ByVal sender As Object, ByVal e As CalculateRouteErrorEventArgs)
			RadMessageBox.ThemeName = Me.CurrentThemeName
			RadMessageBox.Show(e.Error.Message)
		End Sub

        Private Sub radListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radListView1.SelectedIndexChanged
            If Me.radListView1.SelectedItem IsNot Nothing Then
                Dim item As ItineraryItem = TryCast(Me.radListView1.SelectedItem.DataBoundItem, ItineraryItem)

                If item IsNot Nothing Then
                    Me.currentPositionPin.Location = New PointG(item.ManeuverPoint.Coordinates(0), item.ManeuverPoint.Coordinates(1))
                    Me.radMap1.BringIntoView(Me.currentPositionPin.Location)
                End If
            End If
        End Sub

        Private Sub radDropDownListMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListMode.SelectedIndexChanged
            Dim driving As Boolean = CType(Me.radDropDownListMode.SelectedItem.Value, TravelMode) = TravelMode.Driving

            Me.radLabelAvoid.Enabled = driving
            Me.radDropDownListAvoid.Enabled = driving
            Me.radLabelOptimize.Enabled = driving
            Me.radDropDownListOptimize.Enabled = driving
        End Sub
	End Class
End Namespace
