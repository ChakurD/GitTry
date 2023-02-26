using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Dentist : Doctor
    {
        public override void Medication(int deseaceCode)
        {
            deseaceCode = 0;
            Console.WriteLine("Установлена пломба в зубе");
        }
    }
}
