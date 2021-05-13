Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
	Partial Public Class Form1
		Inherits ExamplesForm
		Private store As RadPropertyStore
		Private championships As List(Of Championship)
		Private progressBars As List(Of RadProgressBar)

		Public Sub New()
			InitializeComponent()

            Me.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Hidden
            Me.radPanelCars.PanelElement.PanelBorder.Visibility = ElementVisibility.Hidden
            Me.radPanelCars.PanelElement.PanelFill.Visibility = ElementVisibility.Hidden

            Me.store = Me.CreatePropertyStore()
            Me.championships = Me.CreateChampionships()
            Me.progressBars = New List(Of RadProgressBar)(New RadProgressBar() {Me.radProgressBar1, Me.radProgressBar2, Me.radProgressBar3, Me.radProgressBar4, Me.radProgressBar5})
            Me.radPropertyGrid1.SelectedObject = store
            Me.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical

            Me.ProcessProgressBarValues()

            AddHandler radPropertyGrid1.EditorInitialized, AddressOf radPropertyGrid1_EditorInitialized
            AddHandler radPropertyGrid1.PropertyValueChanged, AddressOf radPropertyGrid1_PropertyValueChanged
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
        End Sub

        Private Sub radPropertyGrid1_PropertyValueChanged(ByVal sender As Object, ByVal e As PropertyGridItemValueChangedEventArgs)
            Me.ProcessProgressBarValues()
        End Sub

        Private Sub radPropertyGrid1_EditorInitialized(ByVal sender As Object, ByVal e As PropertyGridItemEditorInitializedEventArgs)

            Dim editor As PropertyGridSpinEditor = TryCast(e.Editor, PropertyGridSpinEditor)
            If editor Is Nothing Then
                Return
            End If

            Dim element As BaseSpinEditorElement = TryCast(editor.EditorElement, BaseSpinEditorElement)

            Select Case e.Item.Name
                Case "Displacement"
                    element.MinValue = 1
                    element.MaxValue = 10000
                Case "Number of seats"
                    element.MinValue = 1
                    element.MaxValue = 60
                Case "Weight"
                    element.MinValue = 1
                    element.MaxValue = 10000
            End Select
        End Sub

        Private Function CreatePropertyStore() As RadPropertyStore
            Dim vehicleStore As New RadPropertyStore()

            Dim engineLayout As New PropertyStoreItem(GetType(EngineLayout), "Layout", Telerik.Examples.WinControls.PropertyGrid.PropertyStore.EngineLayout.I4, "Engine layout is determined by the configuration of the engine pistons.", "Engine")

            Dim engineDisplacement As New PropertyStoreItem(GetType(Integer), "Displacement", 1600, "Engine displacement is determined from the bore and stroke of the engine's cylinders.", "Engine")

            Dim engineFuel As New PropertyStoreItem(GetType(Fuel), "Fuel", Telerik.Examples.WinControls.PropertyGrid.PropertyStore.Fuel.Petrol, "The type of fuel providing the energy source for the engine.", "Engine")

            Dim engineSupercharged As New PropertyStoreItem(GetType(Boolean), "Turbocharged/Supercharged", True, "Turbocharging/Supercharging is the process of compressing air on the intake of an engine(technical term - Forced induction).", "Engine")

            Dim transmission As New PropertyStoreItem(GetType(Transmission), "Transmission", Telerik.Examples.WinControls.PropertyGrid.PropertyStore.Transmission.SemiAutomatic, "The type of transmission thet would convert the engine power/torque.", "Drivetrain")

            Dim drive As New PropertyStoreItem(GetType(Drive), "Drive", Telerik.Examples.WinControls.PropertyGrid.PropertyStore.Drive.AllWheel, "The configuration of the driving wheels.", "Drivetrain")

            Dim vehicleSeats As New PropertyStoreItem(GetType(Integer), "Number of seats", 2, "The number of seats in the vehicle.", "Other")

            Dim vehicleWeight As New PropertyStoreItem(GetType(Integer), "Weight", 1250, "The minimum wight of the car.", "Other")

            vehicleStore.Add(engineLayout)
            vehicleStore.Add(engineDisplacement)
            vehicleStore.Add(engineFuel)
            vehicleStore.Add(engineSupercharged)
            vehicleStore.Add(transmission)
            vehicleStore.Add(drive)
            vehicleStore.Add(vehicleSeats)
            vehicleStore.Add(vehicleWeight)

            Return vehicleStore
        End Function

        Private Function CreateChampionships() As List(Of Championship)
            Dim wrc As New Championship("WRC", EngineLayout.I4, 1600, Fuel.Petrol, True, Transmission.Manual Or Transmission.SemiAutomatic, Drive.FrontWheel Or Drive.RearWheel Or Drive.AllWheel, 2, 1200)
            Dim formula1 As New Championship("Formula 1", EngineLayout.V8, 2400, Fuel.Petrol, True, Transmission.SemiAutomatic, Drive.RearWheel, 1, 580)
            Dim wtcc As New Championship("WTCC", EngineLayout.I4, 2000, Fuel.Petrol Or Fuel.Diesel, False, Transmission.Manual Or Transmission.SemiAutomatic, Drive.FrontWheel Or Drive.RearWheel, 1, 1200)
            Dim dtm As New Championship("DTM", EngineLayout.V8, 4000, Fuel.Petrol, False, Transmission.SemiAutomatic, Drive.RearWheel, 1, 1050)
            Dim superstars As New Championship("Superstars", EngineLayout.V8, 7000, Fuel.Petrol Or Fuel.Ethanol, False, Transmission.Manual Or Transmission.SemiAutomatic, Drive.RearWheel, 4, 1350)

            Return (New List(Of Championship)(New Championship() {wrc, formula1, wtcc, dtm, superstars}))
        End Function

        Private Function ChampionshipRequirementsMet(ByVal championship As Championship) As Integer
            Dim totalNumberOfRegulations As Integer = Me.store.Count
            Dim numberOfRegulationsMet As Integer = 0

            Dim vehicleSettings As New Championship()
            vehicleSettings.AllowedEngineLayouts = CType(Me.store("Layout").Value, EngineLayout)
            vehicleSettings.MaximumEngineDisplacement = CInt(Fix(Me.store("Displacement").Value))
            vehicleSettings.AllowedFuels = CType(Me.store("Fuel").Value, Fuel)
            vehicleSettings.AllowedEngineSupercharged = CBool(Me.store("Turbocharged/Supercharged").Value)
            vehicleSettings.AllowedTransmissions = CType(Me.store("Transmission").Value, Transmission)
            vehicleSettings.AllowedDrives = CType(Me.store("Drive").Value, Drive)
            vehicleSettings.MinimumNumberOfSeats = CInt(Fix(Me.store("Number of seats").Value))
            vehicleSettings.MinimumVehicleWeight = CInt(Fix(Me.store("Weight").Value))

            If (championship.AllowedEngineLayouts And vehicleSettings.AllowedEngineLayouts) = vehicleSettings.AllowedEngineLayouts Then
                numberOfRegulationsMet += 1
            End If

            If championship.MaximumEngineDisplacement >= vehicleSettings.MaximumEngineDisplacement Then
                numberOfRegulationsMet += 1
            End If

            If (championship.AllowedFuels And vehicleSettings.AllowedFuels) = vehicleSettings.AllowedFuels Then
                numberOfRegulationsMet += 1
            End If

            If championship.AllowedEngineSupercharged OrElse championship.AllowedEngineSupercharged = vehicleSettings.AllowedEngineSupercharged Then
                numberOfRegulationsMet += 1
            End If

            If (championship.AllowedTransmissions And vehicleSettings.AllowedTransmissions) = vehicleSettings.AllowedTransmissions Then
                numberOfRegulationsMet += 1
            End If

            If (championship.AllowedDrives And vehicleSettings.AllowedDrives) = vehicleSettings.AllowedDrives Then
                numberOfRegulationsMet += 1
            End If

            If championship.MinimumNumberOfSeats <= vehicleSettings.MinimumNumberOfSeats Then
                numberOfRegulationsMet += 1
            End If

            If championship.MinimumVehicleWeight <= vehicleSettings.MinimumVehicleWeight Then
                numberOfRegulationsMet += 1
            End If

            Return CInt((numberOfRegulationsMet * 100) / totalNumberOfRegulations)
        End Function

        Private Sub ProcessProgressBarValues()
            For i As Integer = 0 To Me.championships.Count - 1
                Dim requirementsMet As Integer = Me.ChampionshipRequirementsMet(championships(i))
                Me.progressBars(i).Value1 = requirementsMet
            Next i
        End Sub

        'Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        '	MyBase.OnSizeChanged(e)

        '	If Me.radPanel1 IsNot Nothing Then
        '              Me.radPanel1.Location = New Point(CInt((Me.ClientSize.Width - radPanel1.Size.Width) / 2), Me.radPanel1.Location.Y)
        '	End If
        'End Sub

        Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
