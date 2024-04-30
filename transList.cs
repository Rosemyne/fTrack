using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fTrack
{
    // Internal class for storing and processing transactions
    internal class transList
    {
        private List<Transaction> transactions;

        public transList()
        {
            transactions = new List<Transaction>();
        }

        // External access of List
        public List<Transaction> Transactions
        {
            get { return transactions; }
        }

        // Method to add transactions
        public void AddTransaction(int transactionID, int sourceAccountID, int destinationAccountID, double amount, string description)
        {
            transactions.Add(new Transaction(transactionID, sourceAccountID, destinationAccountID, amount, description));
        }

        // Method to process transsactions
        public void ProcessTransaction(accList accountList, Transaction transaction)
        {
            userAccount sourceAccount = null;
            userAccount destinationAccount = null;

            if (transaction.SourceAccountID == -1)
            {
                sourceAccount = new debitAccount();
            } else
            {
                sourceAccount = FindAccount(accountList, transaction.SourceAccountID);
            }

            if (transaction.DestinationAccountID == -1)
            {
                destinationAccount = new creditAccount();
            } else
            {
                destinationAccount = FindAccount(accountList, transaction.DestinationAccountID);
            }

            if (sourceAccount != null && destinationAccount != null)
            {
                // Determine the types of accounts involved in the transaction
                bool isSourceDebit = sourceAccount is debitAccount;
                bool isDestinationDebit = destinationAccount is debitAccount;

                // Handle the different scenarios based on the types of accounts
                if (isSourceDebit && !isDestinationDebit) // Debit to Credit
                {
                    sourceAccount.AccBal -= transaction.Amount;
                    destinationAccount.AccBal -= transaction.Amount;
                }
                else if (isSourceDebit && isDestinationDebit) // Debit to Debit
                {
                    sourceAccount.AccBal -= transaction.Amount;
                    destinationAccount.AccBal += transaction.Amount;
                }
                else if (!isSourceDebit && isDestinationDebit) // Credit to Debit
                {
                    sourceAccount.AccBal += transaction.Amount;
                    destinationAccount.AccBal += transaction.Amount;
                }
            }
        }

        // Method to find account in accList based on accID
        private userAccount FindAccount(accList accountList, int accountID)
        {
            char accountType = accountID.ToString()[0];
            if (accountType == '1')
            {
                foreach (debitAccount account in accountList.getDebitAccount())
                {
                    if (account.AccID == accountID)
                    {
                        return account;
                    }
                }
            } else if (accountType == '2')
            {
                foreach (creditAccount account in accountList.getCredAccount())
                {
                    if (account.AccID == accountID)
                    {
                        return account;
                    }
                }
            }
            return null;
        }

        // Method to save to a file and read from it
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Transaction transaction in transactions)
                {
                    writer.WriteLine($"{transaction.TransactionID},{transaction.SourceAccountID},{transaction.DestinationAccountID},{transaction.Amount},{transaction.Description}");
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            transactions.Clear();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int transactionID = int.Parse(parts[0]);
                int sourceAccountID = int.Parse(parts[1]);
                int destinationAccountID = int.Parse(parts[2]);
                double amount = double.Parse(parts[3]);
                string description = parts[4];

                transactions.Add(new Transaction(transactionID, sourceAccountID, destinationAccountID, amount, description));
            }
        }

        // Gets count of transaction list for external use
        public int TransactionCount
        {
            get { return transactions.Count; }
        }
    }
}
