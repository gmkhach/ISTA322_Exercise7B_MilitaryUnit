using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class Troops : Personnel
    {
        public override void FallIn()
        {
            Console.WriteLine("Your troops are formed up in the parade field, sir!");
        }

    }
}
