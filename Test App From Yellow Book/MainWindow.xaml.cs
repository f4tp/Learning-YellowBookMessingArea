using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_App_From_Yellow_Book
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            /*IF and Exception
                string largerNumberMessage = TestIfStatement.GetIfResult(txtBoxFirst.Text, txtBoxSecond.Text);
                if (largerNumberMessage == "error")
                    MessageBox.Show("The data entered is not numerical");

                else
                    MessageBox.Show(largerNumberMessage);
             */


            /* LOOPS
               LoopsTest.TestDoWhileLoop(txtBoxFirst.Text);
               LoopsTest.TestForLoop(txtBoxSecond.Text);
               LoopsTest.TestIteratorForEach();
            */

            /* STRING FORMATTING
            StringFormatting.OutputFormatting();
            */

            /* REF
            int valueSentFromMain = 20;
            MessageBox.Show($"the value of valueSentFromMain is {valueSentFromMain}");
            TestReferenceParams.testRefValue(ref valueSentFromMain);
            MessageBox.Show($"value from main method call, t valueSentFromMain is now {valueSentFromMain}");
            */

            /* OUT
            string name;
            TestOutParams.RunTestOutParams(out name);
            MessageBox.Show(name);
            */

            /* READER
            ReaderWriterExample.TestReader();
            */
            /*ENUMS
            EnumTest.SetSeaEmptySea();
            EnumTest.SetSeaStateCruiser();
            */
            /* STRUCT and DICTIONARY
            StructAccount RobsAccount = new StructAccount("Rob Whitworth", "address", 000000001, 5000, 500);
            StructAccount DansAccount = new StructAccount("Dan Whitworth", "address", 000000002, 6000, 500);
            StructAccount PetersAccount = new StructAccount("Peter Whitworth", "address", 000000003, 7000, 500);
            StructAccount SandrasAccount = new StructAccount("Sandra Whitworth", "address", 000000004, 8000, 500);
            StructAccount JimmysAccount = new StructAccount("Jimmy Whitworth", "address", 000000005, 9000, 500);
            StructAccount.OutputAllAccountsAsString();
            */
        }
    }
}
