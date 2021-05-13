Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.Scheduler.DataBinding
	Public Class MyResource
		Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
		Private id_Renamed As Guid = Guid.NewGuid()
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String = String.Empty

		Public Sub New(ByVal name As String)
			Me.name_Renamed = name
		End Sub

		Public ReadOnly Property Id() As Guid
			Get
				Return Me.id_Renamed
			End Get
		End Property

		Public Property Name() As String
			Get
				Return Me.name_Renamed
			End Get
			Set(ByVal value As String)
				If Me.name_Renamed <> value Then
					Me.name_Renamed = value
					Me.OnPropertyChanged("Name")
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
