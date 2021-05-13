
namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
{
    public class Championship
    {
        public string Name { get; set; }
        public EngineLayout AllowedEngineLayouts { get; set; }
        public int MaximumEngineDisplacement { get; set; }
        public Fuel AllowedFuels { get; set; }
        public bool AllowedEngineSupercharged { get; set; }
        public Transmission AllowedTransmissions { get; set; }
        public Drive AllowedDrives { get; set; }
        public int MinimumNumberOfSeats { get; set; }
        public int MinimumVehicleWeight { get; set; }

        public Championship()
        { }

        public Championship(string name, EngineLayout allowedLayouts, int maxDisplacement, Fuel allowedFuels,
            bool allowSupercharged, Transmission allowedTransmissions, Drive allowedDrives, int maxNumberOfSeats, int minWight)
        {
            this.Name = name;
            this.AllowedEngineLayouts = allowedLayouts;
            this.MaximumEngineDisplacement = maxDisplacement;
            this.AllowedFuels = allowedFuels;
            this.AllowedEngineSupercharged = allowSupercharged;
            this.AllowedTransmissions = allowedTransmissions;
            this.AllowedDrives = allowedDrives;
            this.MinimumNumberOfSeats = maxNumberOfSeats;
            this.MinimumVehicleWeight = minWight;
        }
    }
}
