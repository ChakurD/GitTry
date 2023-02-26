using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAccountingSystem
{
    public class Registr
    {
        private int numArrIndex;
        public Document[] documents = new Document[10];
        public int NumArrIndex 
        { get { return numArrIndex; }
            set 
            {
                if (value < 11) numArrIndex = value;
                else Console.WriteLine("Регистр заполнен, необходимо использовать другой регистр или очистить данный!");
            }
        }
        
        public Registr() 
        {
            NumArrIndex = 0;
        }

        public void SaveDocumentInRegistr(Document doc ) 
        {
            if (documents[NumArrIndex] == null) documents[NumArrIndex] = doc;
            else
            {
                NumArrIndex++;
                documents[NumArrIndex] = doc;
            }
        }
        public void ShowDocumentInfo(Document doc) 
        {
            doc.ShowDocumentInfo();
        }
    }
}


