using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class TrackedVehicle : Vehicle
    {
        public override void StageVehicles()
        {
            Console.WriteLine("The Abrams and Bradlies are all ready to roll, sir!");
        }
    }
}
