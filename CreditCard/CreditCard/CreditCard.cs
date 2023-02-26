using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class CreditCard
    {
        private string bankAccountNum;
        private decimal currentAccountBalance;

        public CreditCard()
        {
            Console.WriteLine("Введите первоначальную сумму зачисляемую на счет:");
            decimal initAmount = Convert.ToDecimal(Console.ReadLine());
            Random rnd= new Random();
            bankAccountNum = rnd.Next(0, 999999999).ToString() + rnd.Next(0, 999999999).ToString()+ rnd.Next(0, 99).ToString();
            currentAccountBalance = initAmount;
        }

        public void AccrualAmount ()
        {
            Console.WriteLine("Введите сумму которую хотите внести на счет:");
            decimal additionAmount = Convert.ToDecimal(Console.ReadLine());
            currentAccountBalance += additionAmount;
        }

        public void DebitAmount ()
        {
            Console.WriteLine("Введите сумму которую хотите снять со счета:");
            decimal debitAmount = Convert.ToDecimal(Console.ReadLine());
            currentAccountBalance -= debitAmount;
        }

        public void InformAbCrCard()
        {
            Console.WriteLine($"Номер счета: {bankAccountNum}\n Текущий баланс: {currentAccountBalance}");
        }
    }
}
