using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAccountingSystem
{
    class ContractForTheSupplyOfGoods : Document 
    {
        private DateOnly documentDate;
        private int documentNumber;
        private string productType;
        private int productAmount;

        public override DateOnly DocumentDate { get; set; }
        public override int DocumentNumber
        {
            get { return documentNumber; }
            set
            {
                if (value > 0) documentNumber = value;
                else Console.WriteLine("Номер документа не может быть меньше 0");
            }
        }
        public string ProductType { get; set; }
        public int ProductAmount { get; set; }

        public ContractForTheSupplyOfGoods() 
        {
            Console.WriteLine("Введите номер документа: ");
            documentNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип товара: ");
            productType = Console.ReadLine();
            Console.WriteLine("Введите количество товара: ");
            productAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату документа в формате xx-xx-xxxx");
            string dateMonthYear = Console.ReadLine();
            string[] dateMonthYearArr = dateMonthYear.Split('-');
            documentDate = new DateOnly(int.Parse(dateMonthYearArr[2]), int.Parse(dateMonthYearArr[1]), int.Parse(dateMonthYearArr[0]));
        }
    }
}
