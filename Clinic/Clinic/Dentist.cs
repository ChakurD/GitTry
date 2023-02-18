using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Dentist : Clinic
    {
        public override void medication(int deseaceCode)
        {
            deseaceCode = 0;
            Console.WriteLine("Установлена пломба в зубе");
        }
    }
}
