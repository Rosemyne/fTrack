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
using System.Timers;
using System.IO;

namespace fTrack
{
    public partial class MainWindow : Form
    {
        private accList accountList;
        private System.Timers.Timer autoSaveTimer;
        private ComboBox sourceAccountDropdown;
        private ComboBox destinationAccountDropdown;
        private Dictionary<string, int> debitAccountMapping = new Dictionary<string, int>();
        private Dictionary<string, int> creditAccountMapping = new Dictionary<string, int>();
        private transList transactionList = new transList();
        public MainWindow()
        {
            InitializeComponent();
            accountList = new accList();

            // Checks if an accounts.txt file exists, if not, creates one
            if (File.Exists("accounts.txt"))
            {
                accountList.LoadFromFile("accounts.txt");
                genDebitAccList();
                genCreditAccList();
                totalSum();
            } else
            {
                File.Create("accounts.txt");
            }
            // Checks if a transaction.txt file exists, if not, creates one
            if(File.Exists("transactions.txt"))
            {
                transactionList.LoadFromFile("transactions.txt");
                genTransactionHistory();
            } else
            {
                File.Create("transactions.txt");
            }

            // Starts an auto-save timer
            StartAutoSaveTimer();

            // Handles program exit
            Closing += MainWindow_Closing;
        }

        // Handles auto-saving
        private void StartAutoSaveTimer()
        {
            autoSaveTimer = new System.Timers.Timer();
            autoSaveTimer.Elapsed += AutoSaveTimer_Elapsed;
            autoSaveTimer.Interval = TimeSpan.FromMinutes(10).TotalMilliseconds;
            autoSaveTimer.AutoReset = true;
            autoSaveTimer.Start();
        }

        private void AutoSaveTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            accountList.SaveToFile("accounts.txt");
            transactionList.SaveToFile("transactions.txt");
        }

        // Handles saving on program exit
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            accountList.SaveToFile("accounts.txt");
            transactionList.SaveToFile("transactions.txt");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addAccButton_Click(object sender, EventArgs e)
        {
            this.AccBal.Visible = true;
            this.accBalLabel.Visible = true;
            this.AccName.Visible = true;
            this.accNameLabel.Visible = true;
            this.InterestRate.Visible = true;
            this.interestRateLabel.Visible = true;
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
            SetControlsEnabledAndVisible(false);
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
            this.accNameLabel.Visible = false;
            this.accBalLabel.Visible = false;
            this.interestRateLabel.Visible = false;
            this.transDescription.Visible = false;
            this.transAmount.Visible = false;
            this.sourceLabel.Visible = false;
            this.destinationLabel.Visible = false;
            this.transAmountLabel.Visible = false;
            this.transDescriptionLabel.Visible = false;
            genDebitAccList();
            genCreditAccList();
            genTransactionHistory();
            totalSum();
            SetControlsEnabledAndVisible(true);
        }

        private void addDebtButton_Click(object sender, EventArgs e)
        {
            this.AccBal.Visible = true;
            this.accBalLabel.Visible = true;
            this.AccName.Visible = true;
            this.accNameLabel.Visible = true;
            this.InterestRate.Visible = true;
            this.interestRateLabel.Visible = true;
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
            this.transAmount.Visible = true;
            this.transDescription.Visible = true;
            this.sourceLabel.Visible = true;
            this.destinationLabel.Visible = true;
            this.transAmountLabel.Visible = true;
            this.transDescriptionLabel.Visible = true;
            GenerateDropdownItems();
            disableElems();
        }

        private void GenerateDropdownItems()
        {
            LinkedList<debitAccount> debAccounts = accountList.getDebitAccount();
            LinkedList<creditAccount> credAccounts = accountList.getCredAccount();

            sourceAccountDropdown = GenerateComboBox();
            sourceAccountDropdown.Location = new Point(653, 125);
            destinationAccountDropdown = GenerateComboBox();
            destinationAccountDropdown.Location = new Point(653, 154);

            foreach (debitAccount account in debAccounts)
            {
                string accountKey = $"{account.AccName} (ID: {account.AccID})";
                sourceAccountDropdown.Items.Add(accountKey);
                destinationAccountDropdown.Items.Add(accountKey);
            }
            foreach (creditAccount account in credAccounts)
            {
                string accountKey = $"{account.AccName} (ID: {account.AccID})"; 
                sourceAccountDropdown.Items.Add(accountKey);
                destinationAccountDropdown.Items.Add(accountKey);
            }
            if (sourceAccountDropdown.Items.Count > 0)
                sourceAccountDropdown.SelectedIndex = 0;
            if (destinationAccountDropdown.Items.Count > 0)
                destinationAccountDropdown.SelectedIndex = 0;
        }

        private ComboBox GenerateComboBox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Width = 240;
            this.Controls.Add(comboBox);
            return comboBox;
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
            accountList.createDebitAccount(accBal, accName, interestRate);
            returnToMain();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.newAccText.Visible = false;
            DisposeComboBoxes();
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
            accountList.createCreditAccount(accBal, accName, interestRate);
            returnToMain();
        }

        private void transactionAdd_Click(object sender, EventArgs e)
        {
            // Gets the ID from the dropdown boxes
            string selectedSourceAccount = sourceAccountDropdown.SelectedItem.ToString();
            int sourceAccountID = ExtractAccountID(selectedSourceAccount);
            string selectedDestinationAccount = destinationAccountDropdown.SelectedItem.ToString();
            int destinationAccountID = ExtractAccountID(selectedDestinationAccount);
            // Processes rest of transaction handling
            int transactionID = transactionList.TransactionCount + 1;
            double amount;
            if (!double.TryParse(transAmount.Text, out amount))
            {
                amount = 0.00;
            }
            string description = this.transDescription.Text;
            transactionList.AddTransaction(transactionID, sourceAccountID, destinationAccountID, amount, description);
            Transaction lastTransaction = transactionList.Transactions.LastOrDefault();
            transactionList.ProcessTransaction(accountList, lastTransaction);
            DisposeComboBoxes();
            returnToMain();
        }

        private int ExtractAccountID(string selectedItem)
        {
            string[] parts = selectedItem.Split(new[] { " (ID: " }, StringSplitOptions.None);
            if (parts.Length > 1)
            {
                string accountIDStr = parts[1].TrimEnd(')');
                int accountID;
                if (int.TryParse(accountIDStr, out accountID))
                {
                    return accountID;
                }
            }
            return -1;
        }

        // Disposes of dropdown boxes generated by the addition of a transaction

        private void DisposeComboBoxes()
        {
            if (sourceAccountDropdown != null)
            {
                this.Controls.Remove(sourceAccountDropdown);
                sourceAccountDropdown.Dispose();
            }
            if (destinationAccountDropdown != null)
            {
                this.Controls.Remove(destinationAccountDropdown);
                destinationAccountDropdown.Dispose();
            }
        }

        // Method that sets the visibility property of controls
        private void SetControlsEnabledAndVisible(bool enabled)
        {
            foreach (Control control in this.Controls)
            {
                if ((control is Label || control is Panel) && (control.Name.StartsWith("debAccount") || control.Name.StartsWith("credAccount") ||  control.Name.StartsWith("transaction")))
                {
                    control.Enabled = enabled;
                    control.Visible = enabled;
                }
            }
        }

        // Generates transaction list

        private void genTransactionHistory()
        {
            List<Transaction> transactions = transactionList.Transactions;
            int transactionCount = transactions.Count;

            // Clear previous transaction history labels and panels
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.StartsWith("transaction"))
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }
                if (control is Panel panel && panel.Name.StartsWith("transactionPanel"))
                {
                    this.Controls.Remove(panel);
                    panel.Dispose();
                }
            }

            // Generate labels for transaction history
            for (int i = 0; i < transactionCount; i++)
            {
                Transaction transaction = transactions[i];

                // Generates a background panel for appearance and container-looks
                Panel backGroundPanel = new Panel();
                backGroundPanel.Name = "transactionPanel" + (i + 1).ToString();
                backGroundPanel.BackColor = Color.White;
                backGroundPanel.Size = new Size(240, 35);
                backGroundPanel.Location = new Point(662, 130 + (i * 35));
                backGroundPanel.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(backGroundPanel);

                // Generates label for displaying transaction details
                Label transactionLabel = new Label();
                transactionLabel.Text = $"Amount: {transaction.Amount}, Description: {transaction.Description}";
                transactionLabel.Name = "transactionLabel" + (i + 1).ToString();
                transactionLabel.Location = new Point(5, 5);
                transactionLabel.Size = new Size(310, 25);
                transactionLabel.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                transactionLabel.TextAlign = ContentAlignment.MiddleLeft;
                backGroundPanel.Controls.Add(transactionLabel);
            }
        }

        // Generates Debit and Credit Account Lists
        private void genDebitAccList()
        {
            LinkedList<debitAccount> tempDebAccount = accountList.getDebitAccount();
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
            LinkedList<creditAccount> tempCredAccount = accountList.getCredAccount();
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
                LinkedList<debitAccount> tempDebAccount = accountList.getDebitAccount();
                LinkedList<creditAccount> tempCredAccount = accountList.getCredAccount();
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
                LinkedList<debitAccount> tempDebAccount = accountList.getDebitAccount();
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
