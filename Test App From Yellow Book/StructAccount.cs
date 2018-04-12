using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class StructAccount
    {
        public struct Account {public string Name; public string Address; public int AccountNumber; public int Balance; public int Overdraft;};
        public static Dictionary<int, Account> accountHolderDict = new Dictionary<int, Account>();
        public static List<int> allAccountNumbers = new List<int>();
        public StructAccount(string name, string address, int accountnum, int balance, int overdraft)
        
        {
            Account tempAccount = new Account();
            tempAccount.Name = name;
            tempAccount.Address = address;
            tempAccount.AccountNumber = accountnum;
            tempAccount.Balance = balance;
            tempAccount.Overdraft = overdraft;
            StructAccount.accountHolderDict.Add(accountnum, tempAccount);
            StructAccount.allAccountNumbers.Add(accountnum);
        }

        public static void OutputAllAccountsAsString()
        {
            foreach (int tempAccNum in allAccountNumbers)
            {
                Account tempAccount = (Account) GetAccountWithNumber(tempAccNum);
               MessageBox.Show(tempAccount.Name + " " + tempAccount.Address + " " + tempAccount.AccountNumber.ToString() + " " + tempAccount.Balance.ToString() + " " + tempAccount.Overdraft.ToString());

            }
        }

        public static object GetAccountWithNumber(int accountnumin)
        {     
            return accountHolderDict[accountnumin];
        }



    }


}



