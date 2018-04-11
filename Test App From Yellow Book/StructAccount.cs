using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_App_From_Yellow_Book
{
    class StructAccount
    {
        public struct Account {public string Name; public string Address; public int AccountNumber; public int Balance; public int Overdraft; };
        public static object accountHolderDict = new Dictionary<string, string>();

        public StructAccount()
        {

        }



    }


}



