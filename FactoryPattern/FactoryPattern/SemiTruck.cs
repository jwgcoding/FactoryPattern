﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern;

namespace FactoryPattern
{
    internal class SemiTruck :IVehicle
    {
        public SemiTruck()
        {

        }

        public void Drive()
        {
            Console.Clear();
            Console.WriteLine("Please wait for your new vehicle.");
            Thread.Sleep(1000);
            Console.WriteLine("Ding! You have received your new Semi Truck. Now turn the ignition on and start driving!");
        }
    }
}
