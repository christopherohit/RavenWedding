using System;

namespace Telerik.Examples.WinControls.PropertyGrid.PropertyStore
{
    public enum EngineLayout
    {
        I4 = 1,
        I6 = 2, 
        V6 = 4, 
        V8 = 8, 
        V10 = 16, 
        V12 = 32
    }

    public enum Fuel
    {
        Petrol = 1, 
        Diesel = 2, 
        Ethanol = 4, 
        Electric = 8
    }

    public enum Transmission
    {
        Manual = 1, 
        SemiAutomatic = 2, 
        Automatic = 4
    }

    public enum Drive
    {
        FrontWheel = 1, 
        RearWheel = 2, 
        AllWheel = 4
    }
}