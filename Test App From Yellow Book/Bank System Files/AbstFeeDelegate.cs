using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book
{
    public delegate decimal CalculateFee(decimal balance); //delegate method declared outside of class, but in namespace
    abstract class Fee
    {
       

        public static decimal RipOffFee (decimal balancer)
        {
            if (balancer < 0)
            {
                return 100;
            }
            else
            {
                return 1;
            }
        }

        public static decimal FriendlyFee(decimal balance)
        {
            if (balance < 0)
            {
                return 10;
            }
            else
            {
                return 1;
            }
        }

    }
}
