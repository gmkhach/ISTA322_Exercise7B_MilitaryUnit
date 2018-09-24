using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles.Aircrafts
{
    public class Helicopter : Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Whoppa whoppa whopa whoppa");
        }

        public override void Move()
        {
            Console.WriteLine("Helicopter has moved");
        }

        public override void Maintain()
        {
            Console.WriteLine("Helicopter is all over the hanger floor.");
        }

    }
}
