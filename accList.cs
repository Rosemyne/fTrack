using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fTrack
{

    // Internal class for processing and "storing" accounts during run 
    internal class accList
    {
        LinkedList<double> debitAccount = new LinkedList<double>();
        LinkedList<double> creditAccount = new LinkedList<double>();

        public double getID(int accType)
        {
            if (accType == 1)
            {
                debitAccount.AddLast(Convert.ToDouble("1" + debitAccount.Count + 1));
                return debitAccount.Last.Value;
            } else if (accType == 2)
            {
                creditAccount.AddLast(Convert.ToDouble("2" + creditAccount.Count + 1));
                return creditAccount.Last.Value;
            } else
            {
                throw new Exception("Attempted access of account type that does not exist");
            }
        }

    }
}
