using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fTrack
{
    abstract class userAccount
    {
        protected int accID;
        protected int accType;
        protected double accBal;
        protected string accName;
        protected bool isVisible;
        protected double interestRate;

        public abstract void createAccount();

    }
}
