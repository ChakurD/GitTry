﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Surgeon : Doctor
    {
        public override void Medication(int deseaseCode)
        {
            deseaseCode = 0 ;
            Console.WriteLine("Наложен гипс");
        }
    }
}
