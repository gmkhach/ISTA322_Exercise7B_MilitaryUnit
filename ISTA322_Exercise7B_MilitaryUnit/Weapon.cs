﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class Weapon
    {
        public virtual void Fire()
        {
            Console.WriteLine("Boom!");
        }
    }
}
