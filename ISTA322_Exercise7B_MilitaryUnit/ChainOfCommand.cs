﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class ChainOfCommand : Personnel
    {
        public override void FallIn()
        {
            Console.WriteLine("The commanding officer, XO, and top NCO are reporting as requested, sir!");
        }

    }
}
