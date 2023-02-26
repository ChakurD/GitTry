using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Therapist : Doctor
    {
        public override void Medication(int deseaseCode) 
        {
            deseaseCode = 0;
            Console.WriteLine("Выписан рецепт антибиотиков и даны указания по лечению");
        }
    }
}
