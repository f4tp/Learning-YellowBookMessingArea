using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    interface IBank
    {

        IAccount Findaccount(string name);
        bool StoreAccount(IAccount account);
    }
}
