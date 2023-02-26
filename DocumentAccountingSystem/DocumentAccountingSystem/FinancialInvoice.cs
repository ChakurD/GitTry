using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAccountingSystem
{
    public class FinancialInvoice : Document , IShowDocumentInfo
    {
        private decimal finalSumPerMonth;
        private DateOnly documentDate;
        private int documentNum;
        private string departmentCode;

        public decimal FinalSumPerMonth { get; set; }
        public override DateOnly DocumentDate { get; set; }
        public override int DocumentNumber { 
            get { return documentNum; }
            set {
                if (value > 0) documentNum = value;
                else Console.WriteLine("Номер документа не может быть меньше 0");
            }
        }
        public string DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }
        public FinancialInvoice() 
        {
            Console.WriteLine("---- Финансовая накладная -----");
            Console.WriteLine("Введите итоговую сумму за месяц: ");
            finalSumPerMonth = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату документа в формате xx-xx-xxxx");
            string dateMonthYear = Console.ReadLine();
            string[] dateMonthYearArr = dateMonthYear.Split('-');
            documentDate = new DateOnly(int.Parse(dateMonthYearArr[2]), int.Parse(dateMonthYearArr[1]), int.Parse(dateMonthYearArr[0]));
            Console.WriteLine("Введите номер документа: ");
            documentNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите код департамента: ");
            departmentCode = Console.ReadLine();
            Thread.Sleep(400);
            Console.Clear();
        }
        public FinancialInvoice(int docNum, decimal finalSumPerMonth, string departmentCode, string dateMonthYear)
        {
            documentNum = docNum;
            this.finalSumPerMonth = finalSumPerMonth;
            string[] dateMonthYearArr = dateMonthYear.Split('-');
            documentDate = new DateOnly(int.Parse(dateMonthYearArr[2]), int.Parse(dateMonthYearArr[1]), int.Parse(dateMonthYearArr[0]));
            this.departmentCode = departmentCode;
            Thread.Sleep(400);
            Console.Clear();
        }
        public override void ShowDocumentInfo()
        {
            Console.WriteLine($"Финансовая накладная\nДата создания документа: {documentDate}\nНомер Документа: {documentNum}\nОкончательная сумма за месяц: {finalSumPerMonth}\nКод департамента: {departmentCode}");
        }

    }
}
