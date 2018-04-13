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
        public BabyAccount(string namein, string addressin, decimal balancein)
        {
            Name = namein;
            Address = addressin;
            Balance = balancein;
            Overdraft = BABY_ACCOUNT_OVERDRAFT;
            AccountNumber = AbstAccountFields.GetNewAccountNumber();
            AbstDictionaryBank.StoreNewAccount(this);
            SaveAccountToDisk(this.Name, this.Address, this.AccountNumber.ToString(), this.Balance.ToString());
        }

        //these two methods should be elsewhere - in a better placed class, for better cohesiveness / Single responsibility principle
        private bool SaveAccountToDisk(string namein, string addressin, string accountnumin, string balancein)
        {
            try
            {
                System.IO.TextWriter textOut = new System.IO.StreamWriter(accountnumin + " " + namein + ".txt");
                textOut.WriteLine(namein);
                textOut.WriteLine(addressin);
                textOut.WriteLine(accountnumin);
                textOut.WriteLine(balancein);
                textOut.Close();

            }
            catch
            {
                return false;
            }
            return true;
        }
        public static BabyAccount LoadAccountDetails(string filenamein)
        {
            BabyAccount result = null;
            System.IO.TextReader textIn = null;
            try
            {
                textIn = new System.IO.StreamReader(filenamein);
                string nameText = textIn.ReadLine();
                string addressText = textIn.ReadLine();
                string accountText = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                int accountNum = int.Parse(accountText);
                decimal balance = decimal.Parse(balanceText);
                //result = new BabyAccount(nameText, addressText, balance);
                result = (BabyAccount) AbstDictionaryBank.FindAccountWithAccountNum(accountNum);

            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null)
                {
                    textIn.Close();
                }
            }
            return result;
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
            throw new NotImplementedException();
        }

        public void PayInFunds(decimal amount)
        {
            Balance += amount;
        }
    }
}
