using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAccountingSystem
{
    class ContractWithEmployer : Document 
    {
        private int documentNumber;
        private DateOnly documentDate;
        private DateOnly contractEndDate;
        private string emploterName;

        public override int DocumentNumber
        {
            get { return documentNumber; }
            set {if (value > 0) documentNumber = value;
                else Console.WriteLine("Номер документа не может быть меньше 0");
                    }
        }
        public override DateOnly DocumentDate { get; set; }
        
        public DateOnly ContractEndDate { 
            get { return contractEndDate; }
            set { contractEndDate = value; }
        }
        public string EmployerName { get; set; }
        public ContractWithEmployer() 
        {
            Console.WriteLine("Введите номер документа: ");
            documentNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату документа в формате xx-xx-xxxx");
            string dateMonthYear = Console.ReadLine();
            string[] dateMonthYearArr = dateMonthYear.Split('-');
            documentDate = new DateOnly(int.Parse(dateMonthYearArr[2]), int.Parse(dateMonthYearArr[1]), int.Parse(dateMonthYearArr[0]));
            Console.WriteLine("Выберите срок длительности контракта 1, 2, 3, 5");
            int contractEndYear = int.Parse(Console.ReadLine());
            if (contractEndYear == 1 || contractEndYear == 2 || contractEndYear == 3 || contractEndYear == 5) contractEndDate = new DateOnly(int.Parse(dateMonthYearArr[2]) + contractEndYear, int.Parse(dateMonthYearArr[1]), int.Parse(dateMonthYearArr[0]));
            else Console.WriteLine("Неправильно введен срок контракта");
            Console.WriteLine("Введите имя сотрудника: ");
            emploterName = Console.ReadLine();
        }
    }
}
