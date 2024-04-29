using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fTrack
{
    internal class debitAccount: userAccount
    {

        public override void createAccount(int AccID, double AccBal, string AccName, double InterestRate)
        {
            accID = AccID;
            accBal = AccBal;
            accName = AccName;
            interestRate = InterestRate;
        }

    }
}
