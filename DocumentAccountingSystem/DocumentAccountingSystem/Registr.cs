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
        public Object[] documents = new Object[10];
        public int NumArrIndex { get; set; }
        
        public Registr() 
        {
            NumArrIndex = 0;
        }

        public void SaveDocumentInRegistr(Document doc ) 
        {
            documents[NumArrIndex] = doc;
            NumArrIndex++;
        }
        public void ShowDocumentInfo(Object doc) 
        {
        }
    }
}


