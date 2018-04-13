using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool CanWithdrawFunds(decimal amount);
        decimal GetBalance();
        string GetName();
        int GetAccountNum();
        string GetAddress();
   
    
        /*string Tester
        {
            get;
            set;
        }*/
    }
}
