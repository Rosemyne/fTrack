namespace fTrack
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cashTotal = new System.Windows.Forms.Label();
            this.accText = new System.Windows.Forms.Label();
            this.addAccButton = new System.Windows.Forms.Button();
            this.debtText = new System.Windows.Forms.Label();
            this.transHistText = new System.Windows.Forms.Label();
            this.addDebtButton = new System.Windows.Forms.Button();
            this.addTransButton = new System.Windows.Forms.Button();
            this.includeDebtOption = new System.Windows.Forms.CheckBox();
            this.newAccText = new System.Windows.Forms.Label();
            this.newDebtText = new System.Windows.Forms.Label();
            this.newTransText = new System.Windows.Forms.Label();
            this.debtAccAdd = new System.Windows.Forms.Button();
            this.createAccCancel = new System.Windows.Forms.Button();
            this.credAccAdd = new System.Windows.Forms.Button();
            this.transactionAdd = new System.Windows.Forms.Button();
            this.AccName = new System.Windows.Forms.TextBox();
            this.AccBal = new System.Windows.Forms.TextBox();
            this.InterestRate = new System.Windows.Forms.TextBox();
            this.accNameLabel = new System.Windows.Forms.Label();
            this.accBalLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.transAmount = new System.Windows.Forms.TextBox();
            this.transDescription = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.transDescriptionLabel = new System.Windows.Forms.Label();
            this.transAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cashTotal
            // 
            this.cashTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cashTotal.AutoSize = true;
            this.cashTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTotal.Location = new System.Drawing.Point(568, 36);
            this.cashTotal.Name = "cashTotal";
            this.cashTotal.Size = new System.Drawing.Size(119, 46);
            this.cashTotal.TabIndex = 1;
            this.cashTotal.Text = "$0.00";
            this.cashTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accText
            // 
            this.accText.AutoSize = true;
            this.accText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accText.Location = new System.Drawing.Point(58, 124);
            this.accText.Name = "accText";
            this.accText.Size = new System.Drawing.Size(131, 32);
            this.accText.TabIndex = 1;
            this.accText.Text = "Accounts";
            // 
            // addAccButton
            // 
            this.addAccButton.Location = new System.Drawing.Point(326, 124);
            this.addAccButton.Name = "addAccButton";
            this.addAccButton.Size = new System.Drawing.Size(41, 31);
            this.addAccButton.TabIndex = 3;
            this.addAccButton.Text = "+";
            this.addAccButton.UseVisualStyleBackColor = true;
            this.addAccButton.Click += new System.EventHandler(this.addAccButton_Click);
            // 
            // debtText
            // 
            this.debtText.AutoSize = true;
            this.debtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtText.Location = new System.Drawing.Point(483, 127);
            this.debtText.Name = "debtText";
            this.debtText.Size = new System.Drawing.Size(88, 32);
            this.debtText.TabIndex = 4;
            this.debtText.Text = "Debts";
            // 
            // transHistText
            // 
            this.transHistText.AutoSize = true;
            this.transHistText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transHistText.Location = new System.Drawing.Point(882, 127);
            this.transHistText.Name = "transHistText";
            this.transHistText.Size = new System.Drawing.Size(258, 32);
            this.transHistText.TabIndex = 6;
            this.transHistText.Text = "Transaction History";
            // 
            // addDebtButton
            // 
            this.addDebtButton.Location = new System.Drawing.Point(752, 122);
            this.addDebtButton.Name = "addDebtButton";
            this.addDebtButton.Size = new System.Drawing.Size(41, 31);
            this.addDebtButton.TabIndex = 8;
            this.addDebtButton.Text = "+";
            this.addDebtButton.UseVisualStyleBackColor = true;
            this.addDebtButton.Click += new System.EventHandler(this.addDebtButton_Click);
            // 
            // addTransButton
            // 
            this.addTransButton.Location = new System.Drawing.Point(1151, 122);
            this.addTransButton.Name = "addTransButton";
            this.addTransButton.Size = new System.Drawing.Size(41, 31);
            this.addTransButton.TabIndex = 9;
            this.addTransButton.Text = "+";
            this.addTransButton.UseVisualStyleBackColor = true;
            this.addTransButton.Click += new System.EventHandler(this.addTransButton_Click);
            // 
            // includeDebtOption
            // 
            this.includeDebtOption.AutoSize = true;
            this.includeDebtOption.Checked = true;
            this.includeDebtOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeDebtOption.Location = new System.Drawing.Point(576, 85);
            this.includeDebtOption.Name = "includeDebtOption";
            this.includeDebtOption.Size = new System.Drawing.Size(111, 20);
            this.includeDebtOption.TabIndex = 10;
            this.includeDebtOption.Text = "Include Debts";
            this.includeDebtOption.UseVisualStyleBackColor = true;
            this.includeDebtOption.CheckedChanged += new System.EventHandler(this.includeDebtOption_CheckedChanged);
            // 
            // newAccText
            // 
            this.newAccText.AutoSize = true;
            this.newAccText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccText.Location = new System.Drawing.Point(502, 36);
            this.newAccText.Name = "newAccText";
            this.newAccText.Size = new System.Drawing.Size(258, 46);
            this.newAccText.TabIndex = 0;
            this.newAccText.Text = "New Account";
            this.newAccText.Visible = false;
            // 
            // newDebtText
            // 
            this.newDebtText.AutoSize = true;
            this.newDebtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDebtText.Location = new System.Drawing.Point(451, 36);
            this.newDebtText.Name = "newDebtText";
            this.newDebtText.Size = new System.Drawing.Size(353, 46);
            this.newDebtText.TabIndex = 11;
            this.newDebtText.Text = "New Debt Account";
            this.newDebtText.Visible = false;
            // 
            // newTransText
            // 
            this.newTransText.AutoSize = true;
            this.newTransText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTransText.Location = new System.Drawing.Point(473, 36);
            this.newTransText.Name = "newTransText";
            this.newTransText.Size = new System.Drawing.Size(320, 46);
            this.newTransText.TabIndex = 12;
            this.newTransText.Text = "New Transaction";
            this.newTransText.Visible = false;
            // 
            // debtAccAdd
            // 
            this.debtAccAdd.Location = new System.Drawing.Point(459, 475);
            this.debtAccAdd.Name = "debtAccAdd";
            this.debtAccAdd.Size = new System.Drawing.Size(128, 35);
            this.debtAccAdd.TabIndex = 13;
            this.debtAccAdd.Text = "Add";
            this.debtAccAdd.UseVisualStyleBackColor = true;
            this.debtAccAdd.Visible = false;
            this.debtAccAdd.Click += new System.EventHandler(this.debtAccAdd_click);
            // 
            // createAccCancel
            // 
            this.createAccCancel.Location = new System.Drawing.Point(635, 476);
            this.createAccCancel.Name = "createAccCancel";
            this.createAccCancel.Size = new System.Drawing.Size(124, 33);
            this.createAccCancel.TabIndex = 14;
            this.createAccCancel.Text = "Cancel";
            this.createAccCancel.UseVisualStyleBackColor = true;
            this.createAccCancel.Visible = false;
            this.createAccCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // credAccAdd
            // 
            this.credAccAdd.Location = new System.Drawing.Point(459, 476);
            this.credAccAdd.Name = "credAccAdd";
            this.credAccAdd.Size = new System.Drawing.Size(128, 35);
            this.credAccAdd.TabIndex = 17;
            this.credAccAdd.Text = "Add";
            this.credAccAdd.UseVisualStyleBackColor = true;
            this.credAccAdd.Visible = false;
            this.credAccAdd.Click += new System.EventHandler(this.credAccAdd_Click);
            // 
            // transactionAdd
            // 
            this.transactionAdd.Location = new System.Drawing.Point(459, 474);
            this.transactionAdd.Name = "transactionAdd";
            this.transactionAdd.Size = new System.Drawing.Size(128, 35);
            this.transactionAdd.TabIndex = 18;
            this.transactionAdd.Text = "Add";
            this.transactionAdd.UseVisualStyleBackColor = true;
            this.transactionAdd.Visible = false;
            this.transactionAdd.Click += new System.EventHandler(this.transactionAdd_Click);
            // 
            // AccName
            // 
            this.AccName.BackColor = System.Drawing.Color.White;
            this.AccName.Location = new System.Drawing.Point(859, 102);
            this.AccName.Name = "AccName";
            this.AccName.Size = new System.Drawing.Size(333, 22);
            this.AccName.TabIndex = 19;
            this.AccName.Visible = false;
            // 
            // AccBal
            // 
            this.AccBal.BackColor = System.Drawing.Color.White;
            this.AccBal.Location = new System.Drawing.Point(859, 154);
            this.AccBal.Name = "AccBal";
            this.AccBal.Size = new System.Drawing.Size(332, 22);
            this.AccBal.TabIndex = 20;
            this.AccBal.Visible = false;
            // 
            // InterestRate
            // 
            this.InterestRate.BackColor = System.Drawing.Color.White;
            this.InterestRate.Location = new System.Drawing.Point(867, 193);
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.Size = new System.Drawing.Size(325, 22);
            this.InterestRate.TabIndex = 21;
            this.InterestRate.Visible = false;
            // 
            // accNameLabel
            // 
            this.accNameLabel.AutoSize = true;
            this.accNameLabel.Location = new System.Drawing.Point(758, 105);
            this.accNameLabel.Name = "accNameLabel";
            this.accNameLabel.Size = new System.Drawing.Size(95, 16);
            this.accNameLabel.TabIndex = 22;
            this.accNameLabel.Text = "Account Name:";
            this.accNameLabel.Visible = false;
            // 
            // accBalLabel
            // 
            this.accBalLabel.AutoSize = true;
            this.accBalLabel.Location = new System.Drawing.Point(740, 157);
            this.accBalLabel.Name = "accBalLabel";
            this.accBalLabel.Size = new System.Drawing.Size(108, 16);
            this.accBalLabel.TabIndex = 23;
            this.accBalLabel.Text = "Account Balance:";
            this.accBalLabel.Visible = false;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(779, 196);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(82, 16);
            this.interestRateLabel.TabIndex = 24;
            this.interestRateLabel.Text = "Interest Rate:";
            this.interestRateLabel.Visible = false;
            // 
            // transAmount
            // 
            this.transAmount.Location = new System.Drawing.Point(872, 225);
            this.transAmount.Name = "transAmount";
            this.transAmount.Size = new System.Drawing.Size(319, 22);
            this.transAmount.TabIndex = 27;
            this.transAmount.Visible = false;
            // 
            // transDescription
            // 
            this.transDescription.Location = new System.Drawing.Point(872, 120);
            this.transDescription.Name = "transDescription";
            this.transDescription.Size = new System.Drawing.Size(319, 22);
            this.transDescription.TabIndex = 28;
            this.transDescription.Visible = false;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(710, 154);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(145, 16);
            this.sourceLabel.TabIndex = 29;
            this.sourceLabel.Text = "Select Source Account:";
            this.sourceLabel.Visible = false;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(680, 193);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(169, 16);
            this.destinationLabel.TabIndex = 30;
            this.destinationLabel.Text = "Select Destination Account:";
            this.destinationLabel.Visible = false;
            // 
            // transDescriptionLabel
            // 
            this.transDescriptionLabel.AutoSize = true;
            this.transDescriptionLabel.Location = new System.Drawing.Point(775, 124);
            this.transDescriptionLabel.Name = "transDescriptionLabel";
            this.transDescriptionLabel.Size = new System.Drawing.Size(78, 16);
            this.transDescriptionLabel.TabIndex = 31;
            this.transDescriptionLabel.Text = "Description:";
            this.transDescriptionLabel.Visible = false;
            // 
            // transAmountLabel
            // 
            this.transAmountLabel.AutoSize = true;
            this.transAmountLabel.Location = new System.Drawing.Point(797, 228);
            this.transAmountLabel.Name = "transAmountLabel";
            this.transAmountLabel.Size = new System.Drawing.Size(55, 16);
            this.transAmountLabel.TabIndex = 32;
            this.transAmountLabel.Text = "Amount:";
            this.transAmountLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1225, 528);
            this.Controls.Add(this.transAmountLabel);
            this.Controls.Add(this.transDescriptionLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.transDescription);
            this.Controls.Add(this.transAmount);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.accBalLabel);
            this.Controls.Add(this.accNameLabel);
            this.Controls.Add(this.InterestRate);
            this.Controls.Add(this.AccBal);
            this.Controls.Add(this.AccName);
            this.Controls.Add(this.transactionAdd);
            this.Controls.Add(this.credAccAdd);
            this.Controls.Add(this.createAccCancel);
            this.Controls.Add(this.debtAccAdd);
            this.Controls.Add(this.includeDebtOption);
            this.Controls.Add(this.addTransButton);
            this.Controls.Add(this.addDebtButton);
            this.Controls.Add(this.transHistText);
            this.Controls.Add(this.debtText);
            this.Controls.Add(this.addAccButton);
            this.Controls.Add(this.accText);
            this.Controls.Add(this.cashTotal);
            this.Controls.Add(this.newAccText);
            this.Controls.Add(this.newDebtText);
            this.Controls.Add(this.newTransText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cashTotal;
        private System.Windows.Forms.Label accText;
        private System.Windows.Forms.Button addAccButton;
        private System.Windows.Forms.Label debtText;
        private System.Windows.Forms.Label transHistText;
        private System.Windows.Forms.Button addDebtButton;
        private System.Windows.Forms.Button addTransButton;
        private System.Windows.Forms.CheckBox includeDebtOption;
        private System.Windows.Forms.Label newAccText;
        private System.Windows.Forms.Label newDebtText;
        private System.Windows.Forms.Label newTransText;
        private System.Windows.Forms.Button debtAccAdd;
        private System.Windows.Forms.Button createAccCancel;
        private System.Windows.Forms.Button credAccAdd;
        private System.Windows.Forms.Button transactionAdd;
        private System.Windows.Forms.TextBox AccName;
        private System.Windows.Forms.TextBox AccBal;
        private System.Windows.Forms.TextBox InterestRate;
        private System.Windows.Forms.Label accNameLabel;
        private System.Windows.Forms.Label accBalLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.TextBox transAmount;
        private System.Windows.Forms.TextBox transDescription;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label transDescriptionLabel;
        private System.Windows.Forms.Label transAmountLabel;
    }
}

