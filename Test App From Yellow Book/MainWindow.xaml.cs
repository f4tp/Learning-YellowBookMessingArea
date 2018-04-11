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
            /* IF
            string largerNumberMessage = TestIfStatement.GetIfResult(txtBoxFirst.Text, txtBoxSecond.Text);
            if (largerNumberMessage == "error")
                MessageBox.Show("The data entered is not numerical");

            else
                MessageBox.Show(largerNumberMessage);
            */

            LoopsTest.TestDoWhileLoop(txtBoxFirst.Text);

            LoopsTest.TestIteratorForEach();
        }
    }
}
