using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAccountingSystem
{
    public class ContractForTheSupplyOfGoods : Document, IShowDocumentInfo
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
            Console.WriteLine("---- Контракт на поставку товара -----");
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
            Thread.Sleep(400);
            Console.Clear();
        }
        public ContractForTheSupplyOfGoods(int docNum, string prodType, int prodAmount,string dateMonthYear) 
        {
            documentNumber = docNum;
            productType = prodType;
            productAmount = prodAmount;
            string[] dateMonthYearArr = dateMonthYear.Split('-');
            documentDate = new DateOnly(int.Parse(dateMonthYearArr[2]), int.Parse(dateMonthYearArr[1]), int.Parse(dateMonthYearArr[0]));
        }
        public override void ShowDocumentInfo() 
        {
            Console.WriteLine($"Контракт на поставку товара\nДата создания документа: {documentDate}\nНомер Документа: {documentNumber}\nТип Продукта: {productType}\nКоличество продукта: {productAmount}");
        }
    }
}
