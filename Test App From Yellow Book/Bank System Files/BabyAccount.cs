using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    class BabyAccount : AbstAccountFields, IAccount
    {
        const int BABY_ACCOUNT_OVERDRAFT = 0;
        private string _parentName;
        public string ParentName
        {
            get { return _parentName; }
            set { _parentName = value; }
        }

        public BabyAccount(string namein, string addressin, decimal balancein,string parentnamein)
        {
            Name = namein;
            Address = addressin;
            Balance = balancein;
            ParentName = parentnamein;
            Overdraft = BABY_ACCOUNT_OVERDRAFT;
            AccountNumber = AbstAccountFields.GetNewAccountNumber();
            AbstDictionaryBank.StoreNewAccount(this);
            AbstFileHandling.SaveAccountToDisk(this);
        }

        

        public bool CanWithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
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

        public decimal GetBalance()
        {
            return Balance;
        }

        public string GetName()
        {
            return Name;
        }

        public void PayInFunds(decimal amount)
        {
            Balance += amount;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string GetParentName()
        {
            return ParentName;
        }
    }
}
