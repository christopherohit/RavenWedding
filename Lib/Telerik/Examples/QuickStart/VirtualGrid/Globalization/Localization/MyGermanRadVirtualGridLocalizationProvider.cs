using Telerik.WinControls.UI.Localization;

namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
{
    public class MyGermanRadVirtualGridLocalizationProvider : RadVirtualGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadVirtualGridStringId.FilterFunctionBetween: return "Zwischen";
                case RadVirtualGridStringId.FilterOperatorContains: return "Beinhaltet";
                case RadVirtualGridStringId.FilterOperatorDoesNotContain: return "BeinhaltetNicht";
                case RadVirtualGridStringId.FilterOperatorEndsWith: return "EndetMit";
                case RadVirtualGridStringId.FilterOperatorEqualTo: return "IstGleich";
                case RadVirtualGridStringId.FilterOperatorGreaterThan: return "GrößerAls";
                case RadVirtualGridStringId.FilterOperatorGreaterThanOrEqualTo: return "GrößerAlsOderGleich";
                case RadVirtualGridStringId.FilterOperatorIsNull: return "IstNull";
                case RadVirtualGridStringId.FilterOperatorLessThan: return "WenigerAls";
                case RadVirtualGridStringId.FilterOperatorLessThanOrEqualTo: return "WenigerAlsOderGleich";
                case RadVirtualGridStringId.FilterOperatorNoFilter: return "KeinFilter";
                case RadVirtualGridStringId.FilterOperatorNotEqualTo: return "NichtGleich";
                case RadVirtualGridStringId.FilterOperatorNotIsNull: return "NichtNull";
                case RadVirtualGridStringId.FilterOperatorStartsWith: return "StartetMit";
                case RadVirtualGridStringId.FilterOperatorIsLike: return "Wie";
                case RadVirtualGridStringId.FilterOperatorNotIsLike: return "NichtWie";
                case RadVirtualGridStringId.FilterOperatorIsContainedIn: return "EnthaltenIn";
                case RadVirtualGridStringId.FilterOperatorNotIsContainedIn: return "NichtBestandteil";
                case RadVirtualGridStringId.FilterOperatorCustom: return "MaßgeschneidertFunktion";
                case RadVirtualGridStringId.FilterFunctionContains: return "Beinhaltet";
                case RadVirtualGridStringId.FilterFunctionDoesNotContain: return "Beinhaltet nicht";
                case RadVirtualGridStringId.FilterFunctionEndsWith: return "Endet mit";
                case RadVirtualGridStringId.FilterFunctionEqualTo: return "Ist gleich";
                case RadVirtualGridStringId.FilterFunctionGreaterThan: return "Größer als";
                case RadVirtualGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Größer als oder gleich";
                case RadVirtualGridStringId.FilterFunctionIsEmpty: return "Ist leer";
                case RadVirtualGridStringId.FilterFunctionIsNull: return "Ist null";
                case RadVirtualGridStringId.FilterFunctionLessThan: return "Weniger als";
                case RadVirtualGridStringId.FilterFunctionLessThanOrEqualTo: return "Weniger als oder gleich";
                case RadVirtualGridStringId.FilterFunctionNoFilter: return "Kein Filter";
                case RadVirtualGridStringId.FilterFunctionNotBetween: return "Nicht zwischen";
                case RadVirtualGridStringId.FilterFunctionNotEqualTo: return "Nicht gleich";
                case RadVirtualGridStringId.FilterFunctionNotIsEmpty: return "Nicht leer";
                case RadVirtualGridStringId.FilterFunctionNotIsNull: return "Nicht null";
                case RadVirtualGridStringId.FilterFunctionStartsWith: return "Startet mit";
                case RadVirtualGridStringId.FilterFunctionCustom: return "Maßgeschneidert funktion";
                case RadVirtualGridStringId.DeleteRowMenuItem: return "Zeile löschen";
                case RadVirtualGridStringId.SortAscendingMenuItem: return "Sortieren in aufsteigende Reihenfolge";
                case RadVirtualGridStringId.SortDescendingMenuItem: return "Sortieren in absteigende Reihenfolge";
                case RadVirtualGridStringId.ClearSortingMenuItem: return "Sorting löschen";
                case RadVirtualGridStringId.UnpinColumnMenuItem: return "Fixierung aufheben";
                case RadVirtualGridStringId.UnpinRowMenuItem: return "Fixierung der Zeile aufheben";
                case RadVirtualGridStringId.PinAtTopMenuItem: return "Spalte oben fixieren";
                case RadVirtualGridStringId.PinAtBottomMenuItem: return "Spalte unten fixieren";
                case RadVirtualGridStringId.PinMenuItem: return "Spalte fixieren";
                case RadVirtualGridStringId.PinAtLeftMenuItem: return "Spalte links fixieren";
                case RadVirtualGridStringId.PinAtRightMenuItem: return "Spalte rechts fixieren";
                case RadVirtualGridStringId.BestFitMenuItem: return "Beste Passung";
                case RadVirtualGridStringId.PasteMenuItem: return "Einfügen";
                case RadVirtualGridStringId.EditMenuItem: return "Bearbeiten";
                case RadVirtualGridStringId.CopyMenuItem: return "Kopieren";
                case RadVirtualGridStringId.CutMenuItem: return "Ausschneiden";
                case RadVirtualGridStringId.ClearValueMenuItem: return "Wert löschen";
                case RadVirtualGridStringId.AddNewRowString: return "Klicken Sie hier, um eine neue Zeile einzufügen";
                default: return base.GetLocalizedString(id);
            }
        }
    }
}
