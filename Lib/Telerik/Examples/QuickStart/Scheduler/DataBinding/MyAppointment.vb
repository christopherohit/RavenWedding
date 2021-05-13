Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.Scheduler.DataBinding
	Public Class MyAppointment
		Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable start was renamed since Visual Basic does not allow class members with the same name:
		Private start_Renamed As Date = Date.Now
'INSTANT VB NOTE: The variable end was renamed since Visual Basic does not allow class members with the same name:
		Private end_Renamed As Date = Date.Now
'INSTANT VB NOTE: The variable subject was renamed since Visual Basic does not allow class members with the same name:
		Private subject_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable description was renamed since Visual Basic does not allow class members with the same name:
		Private description_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable location was renamed since Visual Basic does not allow class members with the same name:
		Private location_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable visible was renamed since Visual Basic does not allow class members with the same name:
		Private visible_Renamed As Boolean = True
'INSTANT VB NOTE: The variable email was renamed since Visual Basic does not allow class members with the same name:
		Private email_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
		Private id_Renamed As Guid = Guid.NewGuid()
'INSTANT VB NOTE: The variable resources was renamed since Visual Basic does not allow class members with the same name:
		Private resources_Renamed As List(Of MyResource) = Nothing
'INSTANT VB NOTE: The variable exceptions was renamed since Visual Basic does not allow class members with the same name:
		Private exceptions_Renamed As List(Of MyAppointment) = Nothing
'INSTANT VB NOTE: The variable recurrenceRule was renamed since Visual Basic does not allow class members with the same name:
		Private recurrenceRule_Renamed As String = Nothing
'INSTANT VB NOTE: The variable masterAppointment was renamed since Visual Basic does not allow class members with the same name:
		Private masterAppointment_Renamed As MyAppointment = Nothing

		Public Sub New()
		End Sub

		Public Sub New(ByVal start As Date, ByVal [end] As Date, ByVal subject As String, ByVal description As String, ByVal location As String)
			Me.start_Renamed = start
			Me.end_Renamed = [end]
			Me.subject_Renamed = subject
			Me.description_Renamed = description
			Me.location_Renamed = location
		End Sub

		Public ReadOnly Property Id() As Guid
			Get
				Return Me.id_Renamed
			End Get
		End Property

		Public Property Start() As Date
			Get
				Return Me.start_Renamed
			End Get
			Set(ByVal value As Date)
				If Me.start_Renamed <> value Then
					Me.start_Renamed = value
					Me.OnPropertyChanged("Start")
				End If
			End Set
		End Property

		Public Property [End]() As Date
			Get
				Return Me.end_Renamed
			End Get
			Set(ByVal value As Date)
				If Me.end_Renamed <> value Then
					Me.end_Renamed = value
					Me.OnPropertyChanged("End")
				End If
			End Set
		End Property

		Public Property Subject() As String
			Get
				Return Me.subject_Renamed
			End Get
			Set(ByVal value As String)
				If Me.subject_Renamed <> value Then
					Me.subject_Renamed = value
					Me.OnPropertyChanged("Subject")
				End If
			End Set
		End Property

		Public Property Description() As String
			Get
				Return Me.description_Renamed
			End Get
			Set(ByVal value As String)
				If Me.description_Renamed <> value Then
					Me.description_Renamed = value
					Me.OnPropertyChanged("Description")
				End If
			End Set
		End Property

		Public Property Location() As String
			Get
				Return Me.location_Renamed
			End Get
			Set(ByVal value As String)
				If Me.location_Renamed <> value Then
					Me.location_Renamed = value
					Me.OnPropertyChanged("Location")
				End If
			End Set
		End Property

		Public Property Visible() As Boolean
			Get
				Return Me.visible_Renamed
			End Get
			Set(ByVal value As Boolean)
				If Me.visible_Renamed <> value Then
					Me.visible_Renamed = value
					Me.OnPropertyChanged("Visible")
				End If
			End Set
		End Property

		Public Property RecurrenceRule() As String
			Get
				Return Me.recurrenceRule_Renamed
			End Get
			Set(ByVal value As String)
				If Me.recurrenceRule_Renamed <> value Then
					Me.recurrenceRule_Renamed = value
					Me.OnPropertyChanged("RecurrenceRule")
				End If
			End Set
		End Property

		Public Property Email() As String
			Get
				Return Me.email_Renamed
			End Get
			Set(ByVal value As String)
				If Me.email_Renamed <> value Then
					Me.email_Renamed = value
					Me.OnPropertyChanged("Email")
				End If
			End Set
		End Property

		Public ReadOnly Property Resources() As List(Of MyResource)
			Get
				If Me.resources_Renamed Is Nothing Then
					Me.resources_Renamed = New List(Of MyResource)()
				End If

				Return Me.resources_Renamed
			End Get
		End Property

		Public ReadOnly Property Exceptions() As List(Of MyAppointment)
			Get
				If Me.exceptions_Renamed Is Nothing Then
					Me.exceptions_Renamed = New List(Of MyAppointment)()
				End If
				Return Me.exceptions_Renamed
			End Get
		End Property

		Public Property MasterAppointment() As MyAppointment
			Get
				Return Me.masterAppointment_Renamed
			End Get
			Set(ByVal value As MyAppointment)
				If Me.masterAppointment_Renamed IsNot value Then
					Me.masterAppointment_Renamed = value
					Me.OnPropertyChanged("MasterAppointment")
				End If
			End Set
		End Property

		#Region "INotifyPropertyChanged Members"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		#End Region
	End Class
End Namespace
