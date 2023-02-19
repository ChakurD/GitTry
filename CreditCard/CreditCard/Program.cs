namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard masterCardUITBank = new CreditCard();
            CreditCard visaCardAPBank = new CreditCard();
            CreditCard masterCardHoverBank = new CreditCard();

            masterCardUITBank.AccrualAmount();
            visaCardAPBank.AccrualAmount();
            masterCardHoverBank.DebitAmount();

            masterCardUITBank.InformAbCrCard();
            visaCardAPBank.InformAbCrCard();
            masterCardHoverBank.InformAbCrCard();
        }
    }
}