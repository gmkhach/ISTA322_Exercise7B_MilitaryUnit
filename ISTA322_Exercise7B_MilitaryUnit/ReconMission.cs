using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class ReconMission : Mission
    {
        public override void Execute()
        {
            Console.WriteLine("The reconnaissance was successful, sir!");
        }
    }
}
