
Imports Telerik.WinControls.UI.Localization

Namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
	Public Class MyGermanRadVirtualGridLocalizationProvider
		Inherits RadVirtualGridLocalizationProvider
		Public Overrides Function GetLocalizedString(id As String) As String
			Select Case id
				Case RadVirtualGridStringId.FilterFunctionBetween
					Return "Zwischen"
				Case RadVirtualGridStringId.FilterOperatorContains
					Return "Beinhaltet"
				Case RadVirtualGridStringId.FilterOperatorDoesNotContain
					Return "BeinhaltetNicht"
				Case RadVirtualGridStringId.FilterOperatorEndsWith
					Return "EndetMit"
				Case RadVirtualGridStringId.FilterOperatorEqualTo
					Return "IstGleich"
				Case RadVirtualGridStringId.FilterOperatorGreaterThan
					Return "GrößerAls"
				Case RadVirtualGridStringId.FilterOperatorGreaterThanOrEqualTo
					Return "GrößerAlsOderGleich"
				Case RadVirtualGridStringId.FilterOperatorIsNull
					Return "IstNull"
				Case RadVirtualGridStringId.FilterOperatorLessThan
					Return "WenigerAls"
				Case RadVirtualGridStringId.FilterOperatorLessThanOrEqualTo
					Return "WenigerAlsOderGleich"
				Case RadVirtualGridStringId.FilterOperatorNoFilter
					Return "KeinFilter"
				Case RadVirtualGridStringId.FilterOperatorNotEqualTo
					Return "NichtGleich"
				Case RadVirtualGridStringId.FilterOperatorNotIsNull
					Return "NichtNull"
				Case RadVirtualGridStringId.FilterOperatorStartsWith
					Return "StartetMit"
				Case RadVirtualGridStringId.FilterOperatorIsLike
					Return "Wie"
				Case RadVirtualGridStringId.FilterOperatorNotIsLike
					Return "NichtWie"
				Case RadVirtualGridStringId.FilterOperatorIsContainedIn
					Return "EnthaltenIn"
				Case RadVirtualGridStringId.FilterOperatorNotIsContainedIn
					Return "NichtBestandteil"
				Case RadVirtualGridStringId.FilterOperatorCustom
					Return "MaßgeschneidertFunktion"
				Case RadVirtualGridStringId.FilterFunctionContains
					Return "Beinhaltet"
				Case RadVirtualGridStringId.FilterFunctionDoesNotContain
					Return "Beinhaltet nicht"
				Case RadVirtualGridStringId.FilterFunctionEndsWith
					Return "Endet mit"
				Case RadVirtualGridStringId.FilterFunctionEqualTo
					Return "Ist gleich"
				Case RadVirtualGridStringId.FilterFunctionGreaterThan
					Return "Größer als"
				Case RadVirtualGridStringId.FilterFunctionGreaterThanOrEqualTo
					Return "Größer als oder gleich"
				Case RadVirtualGridStringId.FilterFunctionIsEmpty
					Return "Ist leer"
				Case RadVirtualGridStringId.FilterFunctionIsNull
					Return "Ist null"
				Case RadVirtualGridStringId.FilterFunctionLessThan
					Return "Weniger als"
				Case RadVirtualGridStringId.FilterFunctionLessThanOrEqualTo
					Return "Weniger als oder gleich"
				Case RadVirtualGridStringId.FilterFunctionNoFilter
					Return "Kein Filter"
				Case RadVirtualGridStringId.FilterFunctionNotBetween
					Return "Nicht zwischen"
				Case RadVirtualGridStringId.FilterFunctionNotEqualTo
					Return "Nicht gleich"
				Case RadVirtualGridStringId.FilterFunctionNotIsEmpty
					Return "Nicht leer"
				Case RadVirtualGridStringId.FilterFunctionNotIsNull
					Return "Nicht null"
				Case RadVirtualGridStringId.FilterFunctionStartsWith
					Return "Startet mit"
				Case RadVirtualGridStringId.FilterFunctionCustom
					Return "Maßgeschneidert funktion"
				Case RadVirtualGridStringId.DeleteRowMenuItem
					Return "Zeile löschen"
				Case RadVirtualGridStringId.SortAscendingMenuItem
					Return "Sortieren in aufsteigende Reihenfolge"
				Case RadVirtualGridStringId.SortDescendingMenuItem
					Return "Sortieren in absteigende Reihenfolge"
				Case RadVirtualGridStringId.ClearSortingMenuItem
					Return "Sorting löschen"
				Case RadVirtualGridStringId.UnpinColumnMenuItem
					Return "Fixierung aufheben"
				Case RadVirtualGridStringId.UnpinRowMenuItem
					Return "Fixierung der Zeile aufheben"
				Case RadVirtualGridStringId.PinAtTopMenuItem
					Return "Spalte oben fixieren"
				Case RadVirtualGridStringId.PinAtBottomMenuItem
					Return "Spalte unten fixieren"
				Case RadVirtualGridStringId.PinMenuItem
					Return "Spalte fixieren"
				Case RadVirtualGridStringId.PinAtLeftMenuItem
					Return "Spalte links fixieren"
				Case RadVirtualGridStringId.PinAtRightMenuItem
					Return "Spalte rechts fixieren"
				Case RadVirtualGridStringId.BestFitMenuItem
					Return "Beste Passung"
				Case RadVirtualGridStringId.PasteMenuItem
					Return "Einfügen"
				Case RadVirtualGridStringId.EditMenuItem
					Return "Bearbeiten"
				Case RadVirtualGridStringId.CopyMenuItem
					Return "Kopieren"
				Case RadVirtualGridStringId.CutMenuItem
					Return "Ausschneiden"
				Case RadVirtualGridStringId.ClearValueMenuItem
					Return "Wert löschen"
				Case RadVirtualGridStringId.AddNewRowString
					Return "Klicken Sie hier, um eine neue Zeile einzufügen"
				Case Else
					Return MyBase.GetLocalizedString(id)
			End Select
		End Function
	End Class
End Namespace