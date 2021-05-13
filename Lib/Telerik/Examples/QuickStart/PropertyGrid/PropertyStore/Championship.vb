Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
	Public Class Championship
		Public Property Name() As String
		Public Property AllowedEngineLayouts() As EngineLayout
		Public Property MaximumEngineDisplacement() As Integer
		Public Property AllowedFuels() As Fuel
		Public Property AllowedEngineSupercharged() As Boolean
		Public Property AllowedTransmissions() As Transmission
		Public Property AllowedDrives() As Drive
		Public Property MinimumNumberOfSeats() As Integer
		Public Property MinimumVehicleWeight() As Integer

		Public Sub New()
		End Sub

		Public Sub New(ByVal name As String, ByVal allowedLayouts As EngineLayout, ByVal maxDisplacement As Integer, ByVal allowedFuels As Fuel, ByVal allowSupercharged As Boolean, ByVal allowedTransmissions As Transmission, ByVal allowedDrives As Drive, ByVal maxNumberOfSeats As Integer, ByVal minWight As Integer)
			Me.Name = name
			Me.AllowedEngineLayouts = allowedLayouts
			Me.MaximumEngineDisplacement = maxDisplacement
			Me.AllowedFuels = allowedFuels
			Me.AllowedEngineSupercharged = allowSupercharged
			Me.AllowedTransmissions = allowedTransmissions
			Me.AllowedDrives = allowedDrives
			Me.MinimumNumberOfSeats = maxNumberOfSeats
			Me.MinimumVehicleWeight = minWight
		End Sub
	End Class
End Namespace
