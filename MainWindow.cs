using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fTrack
{
    public partial class MainWindow : Form
    {
        accList accList = new accList();
        int tempDebCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addAccButton_Click(object sender, EventArgs e)
        {
            this.AccBal.Visible = true;
            this.AccName.Visible = true;
            this.InterestRate.Visible = true;
            this.newAccText.Visible = true;
            this.createAccCancel.Visible = true;
            this.debtAccAdd.Visible = true;
            disableElems();
        }

        private void disableElems()
        {
            this.cashTotal.Visible = false;
            this.accText.Visible = false; 
            this.debtText.Visible = false;
            this.transHistText.Visible = false;
            this.includeDebtOption.Visible = false;
            this.addAccButton.Visible = false;
            this.addDebtButton.Visible = false;
            this.addTransButton.Visible = false;
        }

        private void returnToMain()
        {
            this.cashTotal.Visible = true;
            this.accText.Visible = true;
            this.debtText.Visible = true;
            this.transHistText.Visible = true;
            this.includeDebtOption.Visible = true;
            this.addAccButton.Visible = true;
            this.addDebtButton.Visible = true;
            this.addTransButton.Visible = true;
            this.debtAccAdd.Visible = false;
            this.createAccCancel.Visible = false;
            this.credAccAdd.Visible = false;
            this.transactionAdd.Visible = false;
            this.newAccText.Visible = false;
            this.newTransText.Visible = false;
            this.newDebtText.Visible = false;
            this.AccBal.Visible = false;
            this.AccName.Visible = false;
            this.InterestRate.Visible = false;
            genDebitAccList();
        }

        private void addDebtButton_Click(object sender, EventArgs e)
        {
            this.newDebtText.Visible = true;
            this.createAccCancel.Visible = true;
            this.credAccAdd.Visible = true;
            disableElems();
        }

        private void addTransButton_Click(object sender, EventArgs e)
        {
            this.newTransText.Visible = true;
            this.createAccCancel.Visible = true;
            this.transactionAdd.Visible = true;
            disableElems();
        }

        private void debtAccAdd_click(object sender, EventArgs e)
        {
            double accBal = Convert.ToDouble(AccBal.Text);
            string accName = Convert.ToString(AccName.Text);
            double interestRate = Convert.ToDouble(InterestRate.Text);
            accList.createDebitAccount(accBal, accName, interestRate);
            returnToMain();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.newAccText.Visible = false;
            returnToMain();
        }

        private void credAccAdd_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        private void transactionAdd_Click(object sender, EventArgs e)
        {
            returnToMain();
        }
        private void enableDebitAccList()
        {

        }
        private void disableDebitAccList() 
        { 
            for (int i = 0; i < tempDebCount; i++)
            {

            }
        }
        private void genDebitAccList()
        {
            LinkedList<debitAccount> tempDebAccount = accList.getDebitAccount();
            tempDebCount = tempDebAccount.Count;
            LinkedListNode<debitAccount> tempNodeDeb = tempDebAccount.Last;
            debitAccount tempDebitAccount = tempNodeDeb.Value;
            TextBox textBox = new TextBox();
            textBox.Text = tempDebitAccount.AccName;
            textBox.Name = "debAccount" + tempDebCount.ToString();
            textBox.Location = new Point(42, 130 + ((tempDebCount - 1) * 30));
            textBox.Font = new Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.ReadOnly = true;
            Controls.Add(textBox);  
        }
    }
}
