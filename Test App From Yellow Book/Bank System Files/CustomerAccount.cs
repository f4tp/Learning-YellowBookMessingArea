using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    public class CustomerAccount : AbstAccountFields, IAccount
    {
        const int CUSTOMER_ACCOUNT_OVERDRAFT = 500;
        public CustomerAccount(string namein, string addressin, decimal balancein)
        {
            Name = namein;
            Address = addressin;
            Balance = balancein;
            Overdraft = CUSTOMER_ACCOUNT_OVERDRAFT;
            AccountNumber = AbstAccountFields.GetNewAccountNumber();
            AbstDictionaryBank.StoreNewAccount(this);
            AbstFileHandling.SaveAccountToDisk(this);
        }


        public bool CanWithdrawFunds(decimal amount)
        {
            if (Balance < amount)
            {
                return false;
            }
            else
            {
                Balance = Balance - amount;
                return true;
            }
        }

        public int GetAccountNum()
        {
            return AccountNumber;
        }

        public string GetAddress()
        {
            return this.Address;
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void PayInFunds(decimal amount)
        {
            Balance += amount;
        }
    }
}
