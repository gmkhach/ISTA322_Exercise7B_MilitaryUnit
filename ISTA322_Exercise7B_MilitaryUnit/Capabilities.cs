using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class Capabilities
    {
        private bool airborne;
        private bool airAssault;
        private bool mountain;
        private bool scuba;
        private bool sapper;
        private bool infantry;
        private bool cavalry;
        private bool artilery;
        private bool aviation;
        
        public void isInfantry()
        {
            Console.WriteLine("Every unit in the military is infantry!");
        }
    }
}
