using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace fTrack
{
    internal class creditAccount: userAccount
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
