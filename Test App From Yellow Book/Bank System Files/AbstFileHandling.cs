using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    public abstract class AbstFileHandling
    {
        static System.IO.StreamWriter textOut;
        static string nameText = "";
        static string addressText = "";
        static string accountText = "";
        static string balanceText = "";
        static string parentText = "";

        public static void SaveAccountToDisk(IAccount iaccountin)
        {
                ExtractGenericAccountData(iaccountin);
                if (iaccountin.GetType() == typeof(CustomerAccount))
                {
                    WriteCustAccToFile();
                }
                else if (iaccountin.GetType() == typeof(BabyAccount))
                {
                    BabyAccount tempBabAcc = (BabyAccount)iaccountin;
                    parentText = tempBabAcc.GetParentName();
                    MessageBox.Show(parentText);
                    WriteBabyAccToFile();
                }
        }
        
        public static void ExtractGenericAccountData(IAccount iaccountin)
        {
            nameText = iaccountin.GetName();
            addressText = iaccountin.GetAddress();
            accountText = iaccountin.GetAccountNum().ToString();
            balanceText = iaccountin.GetBalance().ToString();
 
        }

        public static void WriteCustAccToFile()
        {
            try
            {
                textOut = new System.IO.StreamWriter("Customer Account Details.txt", true);
                textOut.WriteLine(nameText);
                textOut.WriteLine(addressText);
                textOut.WriteLine(accountText);
                textOut.WriteLine(balanceText);
                textOut.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write to / append customer account file");
            }
            
        }
        public static void WriteBabyAccToFile()
        {
            try
            {
                textOut = new System.IO.StreamWriter("Baby Account Details.txt", true);
                textOut.WriteLine(nameText);
                textOut.WriteLine(addressText);
                textOut.WriteLine(accountText);
                textOut.WriteLine(balanceText);
                textOut.WriteLine(parentText);
                textOut.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write to / append Baby account file");
            }
           
        }



        //load baby account details not catered for yet
        public static IAccount LoadAccountDetails(int accountnumin)
        {
            IAccount result = null;
            System.IO.TextReader textIn = null;
            bool foundAccount = false;
            try
            {

                textIn = new System.IO.StreamReader("Customer Account Details.txt");
                do
                {
                    string nameText = textIn.ReadLine();
                    string addressText = textIn.ReadLine();
                    string accountText = textIn.ReadLine();
                    string balanceText = textIn.ReadLine();

                    int accountNum = int.Parse(accountText);
                    if (accountNum == accountnumin)
                    {
                        foundAccount = true;
                        decimal balance = decimal.Parse(balanceText);
                        //result = new BabyAccount(nameText, addressText, balance);
                        result = AbstDictionaryBank.FindAccountWithAccountNum(accountNum);
                    }

                } while (foundAccount == false);
            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null)
                {
                    textIn.Close();
                }
            }
            return result;
        }

    }
}
