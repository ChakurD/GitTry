using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTitle
{
    public class Director : ITittleJob
    {
        private string titleJob;
        private int experience;
        public string TittleJob { get; set; }
        public string Experience { get; set; }

        public Director(int exp)
        {
            this.experience = exp;
            titleJob = "Директор";
        }
        public void TittleJobOut()
        {
            Console.WriteLine($"Должность сотрудника: {titleJob}");
        }
    }
}
