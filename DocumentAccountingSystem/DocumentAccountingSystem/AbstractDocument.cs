using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAccountingSystem
{
    abstract class Document
    {
        public abstract DateOnly DocumentDate { get; set; }
        public abstract int DocumentNumber { get; set; }
        public Document() { }
    }
}
