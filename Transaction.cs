using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fTrack
{
    internal class Transaction
    {
        // Internal class for generating Transactions in transList
        public int TransactionID { get; set; }
        public int SourceAccountID { get; set; }
        public int DestinationAccountID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

        public Transaction(int transactionID, int sourceAccountID, int destinationAccountID, double amount, string description)
        {
            TransactionID = transactionID;
            SourceAccountID = sourceAccountID;
            DestinationAccountID = destinationAccountID;
            Amount = amount;
            Description = description;
        }
    }
}
