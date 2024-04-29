using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fTrack
{
    internal class debitAccount: userAccount
    {

        public override void createAccount()
        {
            accType = 1;
        }
    }
}
