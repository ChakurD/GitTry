using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassword
{
    class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message) { }
        public WrongLoginException() : base("Wrong Login Exception"){ }
    }
}
