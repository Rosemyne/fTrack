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

        public override void createAccount()
        {
            accType = 2;

        }

    }
}
