using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern;

namespace FactoryPattern
{
    internal class VehicleFactory 
    {
        public static IVehicle GetVehicle(int wheelcount)
        {
            switch (wheelcount)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                case 22:
                    return new SemiTruck();
                case 18:
                    return new Wheeler();
                default:
                    return new Car();
            }
        }
    }
}
