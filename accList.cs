using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fTrack
{

    // Internal class for processing and "storing" accounts during run 
    internal class accList
    {
        LinkedList<debitAccount> debAccount = new LinkedList<debitAccount>();
        LinkedList<creditAccount> credAccount = new LinkedList<creditAccount>();
        

        // Creation of Debit and Credit Accounts
        public void createDebitAccount(double AccBal, string AccName, double InterestRate)
        {
            int AccID = int.Parse("1" + (debAccount.Count + 1).ToString());
            debitAccount newDebitAccount = new debitAccount();
            newDebitAccount.createAccount(AccID, AccBal, AccName, InterestRate);
            debAccount.AddLast(newDebitAccount);
        }
        public void createCreditAccount(double AccBal, string AccName, double InterestRate)
        {
            int AccID = int.Parse("2" + (credAccount.Count + 1).ToString());
            creditAccount newCreditAccount = new creditAccount();
            newCreditAccount.createAccount(AccID, AccBal, AccName, InterestRate);
            credAccount.AddLast(newCreditAccount);
        }

        // Creation of Debit and Credit Accounts when instantiating from a file
        public void createDebitAccount(int AccID, double AccBal, string AccName, double InterestRate)
        {
            debitAccount newDebitAccount = new debitAccount();
            newDebitAccount.createAccount(AccID, AccBal, AccName, InterestRate);
            debAccount.AddLast(newDebitAccount);
        }
        public void createCreditAccount(int AccID, double AccBal, string AccName, double InterestRate)
        {
            creditAccount newCreditAccount = new creditAccount();
            newCreditAccount.createAccount(AccID, AccBal, AccName, InterestRate);
            credAccount.AddLast(newCreditAccount);
        }
        // Allows other classes to get deb and cred accounts
        public LinkedList<debitAccount> getDebitAccount()
        {
            return debAccount;
        }
        public LinkedList<creditAccount> getCredAccount()
        {
            return credAccount;
        }

        // Allows saving to and from files
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (debitAccount account in debAccount)
                {
                    writer.WriteLine($"{account.AccID},{account.AccBal},{account.AccName},{account.InterestRate}");
                }
                foreach (creditAccount account in credAccount)
                {
                    writer.WriteLine($"{account.AccID},{account.AccBal},{account.AccName},{account.InterestRate}");
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int accID = int.Parse(parts[0]);
                double accBal = double.Parse(parts[1]);
                string accName = parts[2];
                double interestRate = double.Parse(parts[3]);

                if (accID.ToString().StartsWith("1"))
                {
                    createDebitAccount(accID, accBal, accName, interestRate);
                } else if (accID.ToString().StartsWith("2"))
                {
                    createCreditAccount(accID, accBal, accName, interestRate);
                }
            }
        }
     }
}
