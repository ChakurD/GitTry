namespace DocumentAccountingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var syplyes = new ContractForTheSupplyOfGoods();
            var federal = new FinancialInvoice();
            var employer1 = new ContractWithEmployer();
            var regDoc = new Registr();
            regDoc.SaveDocumentInRegistr(federal);
            regDoc.SaveDocumentInRegistr(syplyes);
            regDoc.SaveDocumentInRegistr(employer1);
            regDoc.ShowDocumentInfo(federal);
            regDoc.ShowDocumentInfo(employer1);
            regDoc.ShowDocumentInfo(syplyes);
        }
    }
}