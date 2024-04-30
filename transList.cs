using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Method to add transactions
        public void AddTransaction(int transactionID, int sourceAccountID, int destinationAccountID, double amount, string description)
        {
            transactions.Add(new Transaction(transactionID, sourceAccountID, destinationAccountID, amount, description));
        }

        // Method to process transsactions
        public void ProcessTransaction(accList accountList, Transaction transaction)
        {
            userAccount sourceAccount = FindAccount(accountList, transaction.SourceAccountID);
            userAccount destinationAccount = FindAccount(accountList, transaction.DestinationAccountID);

            if (sourceAccount != null && destinationAccount != null)
            {
                sourceAccount.AccBal -= transaction.Amount;
                destinationAccount.AccBal += transaction.Amount;
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
    }
}
