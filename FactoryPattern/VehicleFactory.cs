using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch(numberOfTires) 
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                case 8 or 10 or 12 or 18:
                    return new SemiTruck();
                default:
                    return new Car();
            }
        }
    }
}
