using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class TestIfStatement
    {
        public TestIfStatement()
        {

        }

        public static string GetIfResult(string in1, string in2)
        {
            try
            {
                if (int.Parse(in1) > int.Parse(in2))
                    return "number 1 is greater";
                else if(int.Parse(in1) == int.Parse(in2))
                    return "the numbers are equal in size";
                else
                    return "number2 is greater";
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return "error";
            }

        }
        
    }
}
