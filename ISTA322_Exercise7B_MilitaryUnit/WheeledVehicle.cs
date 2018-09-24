using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class WheeledVehicle : Vehicle
    {
        public override void StageVehicles()
        {
            Console.WriteLine("The HMMWVs are ready to roll, sir!");
        }
    }
}
