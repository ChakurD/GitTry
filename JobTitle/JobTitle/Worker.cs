using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTitle
{
    public class Worker : ITittleJob
    {
        private string titleJob;
        private int experience;

        public Worker(int exp) 
        {
        this.experience = exp;
            titleJob= "Рабочий";
        }
        public void TittleJobOut()
        {
            Console.WriteLine($"Должность сотрудника: {titleJob}");
        }
    }
}
