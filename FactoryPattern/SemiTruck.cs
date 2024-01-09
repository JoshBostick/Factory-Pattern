using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern 
{
    public class SemiTruck : IVehicle
    {
        public SemiTruck() { }
        public void Drive()
        {
            Console.WriteLine("You are driving a Big Rig. 10-4 good buddy.");
        }
    }
}
