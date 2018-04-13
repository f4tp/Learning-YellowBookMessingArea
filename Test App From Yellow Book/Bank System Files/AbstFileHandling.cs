using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test_App_From_Yellow_Book.Bank_System_Files
{
    public abstract class AbstFileHandling
    {
  
        public static System.IO.StreamWriter singleWriterInst;
        public static System.IO.StreamReader singleReaderInst;
 

        public static void SaveAccountToDisk(IAccount iaccountin)
        {
            try
            {
                System.IO.StreamWriter textOut = new System.IO.StreamWriter("Account Details.txt", true);
                string nameText = iaccountin.GetName();
                string addressText = iaccountin.GetAddress();
                string accountText = iaccountin.GetAccountNum().ToString();
                string balanceText = iaccountin.GetBalance().ToString();

                textOut.WriteLine(nameText);
                textOut.WriteLine(addressText);
                textOut.WriteLine(accountText);
                textOut.WriteLine(balanceText);
                textOut.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write to / append file");
            }
        }

        public static IAccount LoadAccountDetails(int accountnumin)
        {
            IAccount result = null;
            System.IO.TextReader textIn = null;
            bool foundAccount = false;
                try
                {
                    textIn = new System.IO.StreamReader("Account Details.txt");
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
