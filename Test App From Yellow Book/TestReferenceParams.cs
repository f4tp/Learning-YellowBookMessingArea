using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_App_From_Yellow_Book
{
    class TestReferenceParams
    {

        public TestReferenceParams()
        {

        }
        //couldn;t get this working unless I passed in the textbox and retrieved the
        //text from here, which would be illogical, has use but maybe not for fully modular programs
        //which pipeline data through method calls / between classes
        public static void testRefValue(ref int valuein)
        {
            MessageBox.Show($"The value you passed in is{valuein}");
            valuein += 1;
            MessageBox.Show($"The value has been incremented and is now {valuein}");
        }
    }
}
