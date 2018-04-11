using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class ReaderWriterExample
    {

        public ReaderWriterExample()
        {

        }

        public static void TestReader()
        {
            try
            {
                StreamReader myReader = new StreamReader(@"C:\Users\Quad\Documents\Hello.txt");
                while (myReader.EndOfStream == false)
                {
                    MessageBox.Show(myReader.ReadLine());
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
