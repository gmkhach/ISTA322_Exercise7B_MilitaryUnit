using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles
{
    public class Aircraft : Vehicle
    {
        public virtual void Fly()
        {
            Console.WriteLine("Aircraft is flying.");
        }

        public override void Move()
        {
            Console.WriteLine("The vehicle has moved.");
        }

        public override void Start()
        {
            Console.WriteLine("You shorted the starter with a wrench.");
        }

        public override void Fuel()
        {
            Console.WriteLine("Vehicle is full of fuel.");
        }

        public override void Maintain()
        {
            Console.WriteLine("Vehicle is down for maintenance.");
        }
    }
}
