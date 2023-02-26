namespace DocumentAccountingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContractForTheSupplyOfGoods syplyes = new ContractForTheSupplyOfGoods();
            FinancialInvoice federal= new FinancialInvoice();
            Registr regDoc = new Registr();
            regDoc.SaveDocumentInRegistr(federal);
        }
    }
}