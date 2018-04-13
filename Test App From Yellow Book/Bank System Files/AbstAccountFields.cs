using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    public abstract class AbstAccountFields
    {
        public static List<int> allAccountNumbers;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _accountnumber;
        public int AccountNumber
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }


        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        private int _overdraft;
        public int Overdraft
        {
            get { return _overdraft; }
            set { _overdraft = value; }
        }

        public static int GetNewAccountNumber()
        {
            if (allAccountNumbers == null)
            {
                allAccountNumbers = new List<int>();
                allAccountNumbers.Add(100000000);
                return 100000000;
                
            }
            int lastAccountNumber = AbstAccountFields.allAccountNumbers[allAccountNumbers.Count() - 1];
            int newAccountNum = lastAccountNumber + 1;
            AbstAccountFields.allAccountNumbers.Add(newAccountNum);
            return newAccountNum;
        }
    }
}
