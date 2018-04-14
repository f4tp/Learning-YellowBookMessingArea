using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Exceptions
{
    class BankException : System.Exception
    {
        public BankException(string message) : base(message)
        {

        }
    }
}
