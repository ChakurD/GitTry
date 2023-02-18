using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Surgeon : Clinic
    {
        public override void medication(int deseaseCode)
        {
            deseaseCode = 0 ;
            Console.WriteLine("Наложен гипс");
        }
    }
}
