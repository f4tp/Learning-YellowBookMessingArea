using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    class HashBank : IBank
    {
        Hashtable bankHashTable = new Hashtable();

        public IAccount Findaccount(string name)
        {
            return bankHashTable[name] as IAccount;
        }

        public bool StoreAccount(IAccount account)
        {
            bankHashTable.Add(account.GetName(), account);
            return true;
        }
    }
}
