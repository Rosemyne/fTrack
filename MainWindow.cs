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
            disableAccList();
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
            this.AccBal.Text = "";
            this.AccName.Text = "";
            this.InterestRate.Text = "";
            totalSum();
            enableAccList();
        }

        private void addDebtButton_Click(object sender, EventArgs e)
        {
            this.AccBal.Visible = true;
            this.AccName.Visible = true;
            this.InterestRate.Visible = true;
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
            double accBal;
            string accName = string.IsNullOrEmpty(AccName.Text) ? "default" : AccName.Text;
            double interestRate;
            if (!double.TryParse(AccBal.Text, out accBal))
            {
                accBal = 0.00;
            }
            if (!double.TryParse(InterestRate.Text, out interestRate))
            {
                interestRate = 0.00;
            }
            accList.createDebitAccount(accBal, accName, interestRate);
            genDebitAccList();
            returnToMain();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.newAccText.Visible = false;
            returnToMain();
        }

        private void credAccAdd_Click(object sender, EventArgs e)
        {
            double accBal;
            string accName = string.IsNullOrEmpty(AccName.Text) ? "default" : AccName.Text;
            double interestRate;
            if (!double.TryParse(AccBal.Text, out accBal))
            {
                accBal = 0.00;
            }
            if (!double.TryParse(InterestRate.Text, out interestRate))
            {
                interestRate = 0.00;
            }
            accList.createCreditAccount(accBal, accName, interestRate);
            genCreditAccList();
            returnToMain();
        }

        private void transactionAdd_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        // Disable controls related to accounts
        private void disableAccList()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label && (label.Name.StartsWith("debAccount") || label.Name.StartsWith("credAccount")))
                {
                    label.Enabled = false;
                    label.Visible = false;
                }
                if (control is Panel panel && (panel.Name.StartsWith("debAccount") || panel.Name.StartsWith("credAccount")))
                {
                    panel.Enabled = false;
                    panel.Visible = false;
                }
            }
        }

        // Enable controls related to accounts
        private void enableAccList()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel && (panel.Name.StartsWith("debAccount") || panel.Name.StartsWith("credAccount")))
                {
                    panel.Enabled = true;
                    panel.Visible = true;
                    panel.SendToBack();
                }
                if (control is Label label && (label.Name.StartsWith("debAccount") || label.Name.StartsWith("credAccount")))
                {
                    label.Enabled = true;
                    label.Visible = true;
                    label.BringToFront();
                }
            }
        }

        // Generates Debit and Credit Account Lists
        private void genDebitAccList()
        {
            LinkedList<debitAccount> tempDebAccount = accList.getDebitAccount();
            int tempDebCount = tempDebAccount.Count;

            // Clear previous debit account labels and panels
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.StartsWith("debAccount"))
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }
                if (control is Panel panel && panel.Name.StartsWith("debAccountPanel"))
                {
                    this.Controls.Remove(panel);
                    panel.Dispose();
                }
            }

            // Generate labels for debit accounts
            for (int i = 0; i < tempDebCount; i++)
            {
                debitAccount tempDebitAccount = tempDebAccount.ElementAt(i);

                // Generates a background panel for appearance and container-looks
                Panel backGroundPanel = new Panel();
                backGroundPanel.Name = "debAccountPanel" + (i + 1).ToString();
                backGroundPanel.BackColor = Color.White;
                backGroundPanel.Size = new Size(250, 35);
                backGroundPanel.Location = new Point(42, 130 + (i * 35));
                backGroundPanel.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(backGroundPanel);

                // Generates label for displaying account name
                Label nameLabel = new Label();
                nameLabel.Text = tempDebitAccount.AccName;
                nameLabel.Name = "debAccountName" + (i + 1).ToString();
                nameLabel.Location = new Point(5, 5);
                nameLabel.Size = new Size(150, 25);
                nameLabel.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameLabel.TextAlign = ContentAlignment.MiddleLeft;
                backGroundPanel.Controls.Add(nameLabel);

                // Generates label for displaying account balance
                Label balanceLabel = new Label();
                balanceLabel.Text = tempDebitAccount.AccBal.ToString("C2");
                balanceLabel.Name = "debAccountBalance" + (i + 1).ToString();
                balanceLabel.Location = new Point(100, 5);
                balanceLabel.Size = new Size(150, 25);
                balanceLabel.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                balanceLabel.TextAlign = ContentAlignment.MiddleRight;
                backGroundPanel.Controls.Add(balanceLabel);
            }
        }
        private void genCreditAccList()
        {
            LinkedList<creditAccount> tempCredAccount = accList.getCredAccount();
            int tempCredCount = tempCredAccount.Count;

            // Clear previous credit account labels and panels
            foreach (Control control in this.Controls) 
            {  
                if (control is Label label && label.Name.StartsWith("credAccount"))
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }
                if (control is Panel panel && panel.Name.StartsWith("credAccount"))
                {
                    this.Controls.Remove(panel);
                    panel.Dispose();
                }
            }

            // Generate labels for credit accounts
            for (int i = 0; i< tempCredCount; i++)
            {
                creditAccount tempCreditAccount = tempCredAccount.ElementAt(i);

                // Generates a background panel for appearance and container-looks
                Panel backGroundPanel = new Panel();
                backGroundPanel.Name = "credAccountPanel" + (i + 1).ToString();
                backGroundPanel.BackColor = Color.White;
                backGroundPanel.Size = new Size(250, 35);
                backGroundPanel.Location = new Point(365, 130 + (i * 35));
                backGroundPanel.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(backGroundPanel);

                // Generates label for displaying account name
                Label nameLabel = new Label();
                nameLabel.Text = tempCreditAccount.AccName;
                nameLabel.Name = "credAccountName" + (i + 1).ToString();
                nameLabel.Location = new Point(5, 5);
                nameLabel.Size = new Size(150, 25);
                nameLabel.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameLabel.TextAlign = ContentAlignment.MiddleLeft;
                backGroundPanel.Controls.Add(nameLabel);

                // Generates label for displaying account balance
                Label balanceLabel = new Label();
                balanceLabel.Text = tempCreditAccount.AccBal.ToString("C2");
                balanceLabel.Name = "credAccountBalance" + (i + 1).ToString();
                balanceLabel.Location = new Point(100, 5);
                balanceLabel.Size = new Size(150, 25);
                balanceLabel.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                balanceLabel.TextAlign = ContentAlignment.MiddleRight;
                backGroundPanel.Controls.Add(balanceLabel);
            }
        }

        // Provides a method for calculating the total balance in all of the accounts
        private void totalSum()
        {
            if (includeDebtOption.Checked == true)
            {
                LinkedList<debitAccount> tempDebAccount = accList.getDebitAccount();
                LinkedList<creditAccount> tempCredAccount = accList.getCredAccount();
                int tempDebCount = tempDebAccount.Count;
                int tempCredCount = tempCredAccount.Count;
                double tempAccBal = 0;
                for (int i = 0; i < tempDebCount; i++)
                {
                    debitAccount tempDebitAccount = tempDebAccount.ElementAt(i);
                    tempAccBal += tempDebitAccount.AccBal;
                }
                for (int i = 0; i <  tempCredCount; i++)
                {
                    creditAccount tempCreditAccount = tempCredAccount.ElementAt(i);
                    tempAccBal -= tempCreditAccount.AccBal;
                }
                cashTotal.Text = "$" + tempAccBal.ToString("N");
            } else
            {
                LinkedList<debitAccount> tempDebAccount = accList.getDebitAccount();
                int tempDebCount = tempDebAccount.Count;
                double tempAccBal = 0;
                for (int i = 0; i < tempDebCount; i++)
                {
                    debitAccount tempDebitAccount = tempDebAccount.ElementAt(i);
                    tempAccBal += tempDebitAccount.AccBal;
                }
                cashTotal.Text = "$" + tempAccBal.ToString("N");
            }
            int center = this.ClientSize.Width / 2;
            this.cashTotal.Location = new Point(center - (this.cashTotal.Width / 2), this.cashTotal.Location.Y);
        }

        private void includeDebtOption_CheckedChanged(object sender, EventArgs e)
        {
            totalSum();
        }
    }
}
