using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class StringFormatting
    {
        public StringFormatting()
        {

        }


        public static void OutputFormatting()
        {
            
            int i = 150;
            double f = 1234.5678;

            //1
            string messageToShow = String.Format("i: {0}, f: {1}", i.ToString(), f.ToString());
            MessageBox.Show(messageToShow);

            //2
            string message2 = String.Format("i: {0:0} f: {1:0:00}", i, f);
            MessageBox.Show(message2);

            //3
            string message3 = String.Format("i: {0:0000} f: {1:00000.00}", i, f);
            MessageBox.Show(message3);

            //4
            string message4 = String.Format("i: {0:,##0} f: {1:##,##0.00}", i, f );
            MessageBox.Show(message4);

        

        }

    }


}
