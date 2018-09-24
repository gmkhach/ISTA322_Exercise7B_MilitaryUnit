using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles
{
    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("The vehicle has moved.");
        }

        public virtual void Start()
        {
            Console.WriteLine("You shorted the starter with a wrench.");
        }

        public virtual void Fuel()
        {
            Console.WriteLine("Vehicle is full of fuel.");
        }

        public virtual void Maintain()
        {
            Console.WriteLine("Vehicle is down for maintenance.");
        }
    }
}
