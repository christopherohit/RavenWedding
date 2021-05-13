Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls

Namespace HotelApp.Data
	Public NotInheritable Class Utils
		Public Shared MainThemeColor As Color
		Public Shared MainFont As String = "Roboto"
		Public Shared MainFontMedium As String = "Roboto Medium"

		Private Sub New()
		End Sub
		Public Shared Function GetHouseKeeperIdByName(ByVal name As String, ByVal houseKeepers As BindingList(Of HouseKeeper)) As Integer?
			Dim id? As Integer = Nothing
			For Each hk As HouseKeeper In houseKeepers
				If hk.Name = name Then
					Return hk.Id
				End If
			Next hk
			Return id
		End Function

		Public Shared Function GetHouseKeepingStatus(ByVal houseKeepingStatus_Renamed As HouseKeepingStatus) As String
			Select Case houseKeepingStatus_Renamed
				Case HouseKeepingStatus.Clean
					Return "Clean"
				Case HouseKeepingStatus.NotClean
					Return "Not clean"
				Case HouseKeepingStatus.InProgress
					Return "In progress"
				Case Else
					Return "N/A"
			End Select
		End Function

		Public Shared Function GetRoomType(ByVal roomType_Renamed As RoomType) As String
			Select Case roomType_Renamed
				Case RoomType.Single
					Return "Single"
				Case RoomType.Double
					Return "Double"
				Case RoomType.Triple
					Return "Triple" '"Family (3)";
				Case RoomType.Family
					Return "Family" '"Family (4)";
				Case Else
					Return "N/A"
			End Select
		End Function

		Friend Shared Function GetImageByRoomType(ByVal roomType_Renamed As RoomType) As Image
			Select Case ThemeResolutionService.ApplicationThemeName
				Case "Material"
					Return GetImageByRoomTypeMaterial(roomType_Renamed)
				Case "MaterialPink"
					Return GetImageByRoomTypeMaterialPink(roomType_Renamed)
				Case "MaterialTeal"
					Return GetImageByRoomTypeMaterialTeal(roomType_Renamed)
				Case "MaterialBlueGrey"
					Return GetImageByRoomTypeMaterialBlueGrey(roomType_Renamed)
				Case Else
					Return My.Resources.free_room
			End Select
		End Function

		Friend Shared Function GetImageByRoomTypeMaterial(ByVal roomType_Renamed As RoomType) As Image
			Select Case roomType_Renamed
				Case RoomType.Single
					Return My.Resources.single_user_orange
				Case RoomType.Double
					Return My.Resources.double_user_orange
				Case RoomType.Triple
					Return My.Resources.tripple_user_orange
				Case RoomType.Family
					Return My.Resources.family_user_orange
				Case Else
					Return My.Resources.free_room
			End Select
		End Function

		Friend Shared Function GetImageByRoomTypeMaterialPink(ByVal roomType_Renamed As RoomType) As Image
			Select Case roomType_Renamed
				Case RoomType.Single
					Return My.Resources.single_user_blue
				Case RoomType.Double
					Return My.Resources.double_user_blue
				Case RoomType.Triple
					Return My.Resources.tripple_user_blue
				Case RoomType.Family
					Return My.Resources.family_user_blue
				Case Else
					Return My.Resources.free_room_pink
			End Select
		End Function

		Friend Shared Function GetImageByRoomTypeMaterialTeal(ByVal roomType_Renamed As RoomType) As Image
			Select Case roomType_Renamed
				Case RoomType.Single
					Return My.Resources.single_user_red
				Case RoomType.Double
					Return My.Resources.double_user_red
				Case RoomType.Triple
					Return My.Resources.tripple_user_red
				Case RoomType.Family
					Return My.Resources.family_user_red
				Case Else
					Return My.Resources.free_room_teal
			End Select
		End Function

		Friend Shared Function GetImageByRoomTypeMaterialBlueGrey(ByVal roomType_Renamed As RoomType) As Image
			Select Case roomType_Renamed
				Case RoomType.Single
					Return My.Resources.single_user_green
				Case RoomType.Double
					Return My.Resources.double_user_green
				Case RoomType.Triple
					Return My.Resources.tripple_user_green
				Case RoomType.Family
					Return My.Resources.family_user_green
				Case Else
					Return My.Resources.free_room_bluegrey
			End Select
		End Function

		Friend Shared Function GetRoomIconByType(ByVal roomType_Renamed As RoomType) As Image
			Select Case roomType_Renamed
				Case RoomType.Single
					Return My.Resources.single_user
				Case RoomType.Double
					Return My.Resources.double_users
				Case RoomType.Triple
					Return My.Resources.tripple_users
				Case RoomType.Family
					Return My.Resources.family_users
				Case Else
					Return Nothing
			End Select
		End Function

		Friend Shared Function GetRoomIconByHouseKeepingStatus(ByVal houseKeepingStatus_Renamed As HouseKeepingStatus) As Image
			Select Case houseKeepingStatus_Renamed
				Case HouseKeepingStatus.Clean
					Return My.Resources.GlyphCheck_small
				Case HouseKeepingStatus.NotClean
					Return My.Resources.GlyphClose
				Case HouseKeepingStatus.InProgress
					Return My.Resources.clock_small
				Case Else
					Return Nothing
			End Select
		End Function

		Friend Shared Function GetRoomById(ByVal roomId As Integer, ByVal rooms As BindingList(Of Room)) As Room
			Dim r As Room = Nothing
			For Each room_Renamed As Room In rooms
				If room_Renamed.Id = roomId Then
					Return room_Renamed
				End If
			Next room_Renamed
			Return r
		End Function

		Friend Shared Function GetRoomStatus(ByVal roomStatus_Renamed As RoomStatus) As String
			Select Case roomStatus_Renamed
				Case RoomStatus.Reserved
					Return "Reserved"
				Case RoomStatus.Occupied
					Return "Occupied"
				Case RoomStatus.Available
					Return "Available"
				Case RoomStatus.CheckedOut
					Return "Checked-Out"
				Case Else
					Return "N/A"
			End Select
		End Function

		Friend Shared Function GetRoomImageByRoomType(ByVal roomType_Renamed As RoomType) As Image
			Select Case roomType_Renamed
				Case RoomType.Single
					Return My.Resources.single
				Case RoomType.Double
					Return My.Resources._double
				Case RoomType.Triple
					Return My.Resources.tripple
				Case RoomType.Family
					Return My.Resources.family
				Case Else
					Return Nothing
			End Select
		End Function

		Public Shared Function GetBookingTypeByStatus(ByVal bk As BookingStatus) As String
			Select Case bk
				Case BookingStatus.Reservation
					Return "Reservation"
				Case BookingStatus.Actual
					Return "Actual"
				Case BookingStatus.Cancelled
					Return "Cancelled"
				Case BookingStatus.CheckedOut
					Return "Checked out"
				Case BookingStatus.NoShow
					Return "No-show"
				Case Else
					Return "N/A"
			End Select
		End Function

		Public Shared Function GetGuestById(ByVal guests As BindingList(Of Guest), ByVal id As String) As Guest
			Dim g As Guest = Nothing
			For Each guest_Renamed As Guest In guests
				If guest_Renamed.Id = id Then
					Return guest_Renamed
				End If
			Next guest_Renamed
			Return g
		End Function

		Friend Shared Function GetAvailableImageByTheme() As Image
			Select Case ThemeResolutionService.ApplicationThemeName
				Case "Material"
					Return My.Resources.free_room
				Case "MaterialPink"
					Return My.Resources.free_room_pink
				Case "MaterialTeal"
					Return My.Resources.free_room_teal
				Case "MaterialBlueGrey"
					Return My.Resources.free_room_bluegrey
				Case Else
					Return My.Resources.free_room
			End Select
		End Function
	End Class
End Namespace