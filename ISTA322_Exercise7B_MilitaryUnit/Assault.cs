using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class Assault : Mission
    {
        public override void Execute()
        {
            Console.WriteLine("The target was destroyed, sir!");
        }
    }
}
