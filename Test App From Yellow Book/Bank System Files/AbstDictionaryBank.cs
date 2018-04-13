using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    public abstract class AbstDictionaryBank
    {

       static Dictionary<int, IAccount> accountDictionary = new Dictionary<int, IAccount>();

        public static IAccount FindAccountWithAccountNum(int accountnumin)
        {
            if (accountDictionary.ContainsKey(accountnumin))
            {
                return accountDictionary[accountnumin];
            }
            else
            {
                return null;
            }
        }


        public static bool StoreNewAccount (IAccount accountin)
        {
            if (accountDictionary.ContainsKey(accountin.GetAccountNum()))
            {
                Console.WriteLine("The account already exists");
                return false;
            }
            else
            {
                accountDictionary.Add(accountin.GetAccountNum(), accountin);
                Console.WriteLine("The accoutn has been created");
                return true;
            }
        }

    }
}
