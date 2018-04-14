using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using Test_App_From_Yellow_Book.Bank_System_Files;
using Test_App_From_Yellow_Book.Thread_Work;

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

            StructAccount.TestDictAccessWithValue(000000001);
            */

            /* My STRUCT FILE CALL
                structExample tester = new structExample(5, 3);
                MessageBox.Show(tester.GetIntOne().ToString());
                MessageBox.Show(tester.GetIntTwo().ToString());
            */

            /*My STRUCT FILE CALL WITHOUT CREATING IT LIKE AN OBJECT
            structExampleNoInst testNoInst;
            testNoInst.IntOneTester = 50;
            testNoInst.IntTwoTester = 30;
            MessageBox.Show(testNoInst.IntOneTester.ToString());
            MessageBox.Show(testNoInst.IntTwoTester.ToString());
            */


            /*DELEGATES
                CalculateFee ripFee = new CalculateFee(Fee.RipOffFee);
                decimal ripFeeInt = ripFee(-1);
                MessageBox.Show(ripFeeInt.ToString());
                CalculateFee friendFee = new CalculateFee(Fee.FriendlyFee);
                decimal friendFeeInt = friendFee(-1);
                MessageBox.Show(friendFeeInt.ToString());
            */

            /* ARRAY LIST Vs LIST
                ArrayList multipleDataTypeArrayList = new ArrayList(); //can contain multiple data types, is not  a generic collection
                List<string> specificList = new List<string>(); //just contains strings, is a generic collection
            */

            /* BANK WORK
                IAccount custRob = new CustomerAccount("Rob Whitworth", "address", 1000);
                IAccount custPeter = new CustomerAccount("Peter Whitworth", "address", 2000);
                IAccount babySandra = new BabyAccount("Sandra Whitworth", "address", 3000, "Rob Whitworth");
                IAccount babyLaura = new BabyAccount("Laura Whitworth", "address", 4000, "Peter Whitworth");

                IAccount foundAccount = AbstFileHandling.LoadAccountDetails(100000000);
                MessageBox.Show(foundAccount.GetName());
            */

            /* THREADS WORK
                ThreadStart busyLoopMethod = new ThreadStart(ThreadExample.BusyLoop);
                ThreadStart busyLoopMethodTwo = new ThreadStart(ThreadExample.BusyLoopTwo);
                Thread t1 = new Thread(busyLoopMethod);
                Thread t2 = new Thread(busyLoopMethodTwo);
                t1.Start();
                t2.Start();
            */

            /* MUTUAL EXCLUSION WORK SYNC MONITOR.ENTER MONITOR.EXIT

                 ThreadStart mutExMethod = new ThreadStart(ThreadWorkMutulExSync.BusyLoopMutEx);

                 for (int i = 0; i < 50; i +=1)
                 {
                     Thread t1 = new Thread(ThreadWorkMutulExSync.BusyLoopMutEx);
                     t1.Start();
                 }


                 //ThreadStart noMutExMethod = new ThreadStart(ThreadWorkMutulExSync.BusyLoopNoMutEx);

                // for (int i = 0; i < 50; i += 1)
                // {
                    // Thread t1 = new Thread(ThreadWorkMutulExSync.BusyLoopNoMutEx);
                    // t1.Start();
                 //}
             */
            /* PROCESS EXAMPLE
                Process.Start("Notepad.exe");
                //you can create processes like threads, but each process 'object' has its own memory allocation
                //and not a shared allocation memopry block like threads use
            */





        }
    }
}
