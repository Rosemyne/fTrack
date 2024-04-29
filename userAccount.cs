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
        protected double accBal;
        protected string accName;
        protected bool isVisible;
        protected double interestRate;

        public abstract void createAccount(int AccID, double AccBal, String AccName, double InterestRate);

        public int AccID {  get { return accID; } }
        public double AccBal { get {  return accBal; } }
        public string AccName { get {  return accName; } }
        public double InterestRate { get {  return interestRate; } }
        public bool IsVisible { get { return isVisible; } }
    }
}
