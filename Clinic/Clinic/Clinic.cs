using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Clinic
    {
        public int numbOfDoctor { get; set; }
        public virtual int codeTreatment { get; set; } = 0;
        public virtual void medication(int deseaseCode) 
        {
            Console.WriteLine("Лечение");
        }
    }
}
