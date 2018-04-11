using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class LoopsTest
    {

        public LoopsTest()
        {
                
        }

        public static void TestDoWhileLoop (string input)
        {
            try
            {
                int i = 0;
                do
                {
                    MessageBox.Show("i = " + i);
                    i += 1;
                }
                while (i <= int.Parse(input));
            }
            catch
            {
                MessageBox.Show("please check the data entered is numerical");
            }
        }

        public static void TestWhileLoop(string input)
        {
            try
            {
                int i = 0;
                while (i <= int.Parse(input))
                {
                    MessageBox.Show("i = " + i);
                    i += 1;
                }
            }
            catch
            {
                MessageBox.Show("please check the data entered is numerical");
            }
        }

        public static void TestForLoop(string input)
        {
            try
            {
                for (int i = 0; i <= int.Parse(input); i += 1)
                {
                    MessageBox.Show("i = " + i);
                }
            }
            catch
            {
                MessageBox.Show("please check the data entered is numerical");
            }
        }

        public static void TestIteratorForEach ()
        {
            string[] arrNames = { "Damien", "Peter", "Ethel", "Chase" };
            
            foreach (string tempName in arrNames)
            {
                MessageBox.Show(tempName);
            }
        }
    }
}
