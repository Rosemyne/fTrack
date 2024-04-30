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

        public int AccID { get { return accID; } }
        public double AccBal { get {  return accBal; } set { accBal = value; } }
        public string AccName { get {  return accName; } set { accName = value; } }
        public double InterestRate { get {  return interestRate; } set { interestRate = value; } }
        public bool IsVisible { get { return isVisible; } set { isVisible = value; } }
    }
}
