namespace DocumentAccountingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContractForTheSupplyOfGoods syplyes = new ContractForTheSupplyOfGoods();
            FinancialInvoice federal = new FinancialInvoice();
            ContractWithEmployer employer1 = new ContractWithEmployer();
            Registr regDoc = new Registr();
            regDoc.SaveDocumentInRegistr(federal);
            regDoc.SaveDocumentInRegistr(syplyes);
            regDoc.SaveDocumentInRegistr(employer1);
            regDoc.ShowDocumentInfo(federal);
            regDoc.ShowDocumentInfo(employer1);
            regDoc.ShowDocumentInfo(syplyes);
        }
    }
}