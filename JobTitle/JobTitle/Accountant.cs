using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTitle
{
    public class Accountant : ITittleJob
    {
        private string titleJob;
        private int experience;

        public Accountant(int exp)
        {
            this.experience = exp;
            titleJob = "Бухгалтер";
        }
        public void TittleJobOut()
        {
            Console.WriteLine($"Должность сотрудника: {titleJob}");
        }
    }
}
