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
            this.AccountsText = new System.Windows.Forms.Label();
            this.creditAccBox = new System.Windows.Forms.ListBox();
            this.addAccButton = new System.Windows.Forms.Button();
            this.DebtText = new System.Windows.Forms.Label();
            this.debtAccBox = new System.Windows.Forms.ListBox();
            this.transHistText = new System.Windows.Forms.Label();
            this.transHistBox = new System.Windows.Forms.ListBox();
            this.debtAccButton = new System.Windows.Forms.Button();
            this.transAddButton = new System.Windows.Forms.Button();
            this.includeDebtOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cashTotal
            // 
            this.cashTotal.AutoSize = true;
            this.cashTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTotal.Location = new System.Drawing.Point(568, 36);
            this.cashTotal.Name = "cashTotal";
            this.cashTotal.Size = new System.Drawing.Size(119, 46);
            this.cashTotal.TabIndex = 0;
            this.cashTotal.Text = "$0.00";
            // 
            // AccountsText
            // 
            this.AccountsText.AutoSize = true;
            this.AccountsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsText.Location = new System.Drawing.Point(58, 124);
            this.AccountsText.Name = "AccountsText";
            this.AccountsText.Size = new System.Drawing.Size(131, 32);
            this.AccountsText.TabIndex = 1;
            this.AccountsText.Text = "Accounts";
            // 
            // creditAccBox
            // 
            this.creditAccBox.FormattingEnabled = true;
            this.creditAccBox.ItemHeight = 16;
            this.creditAccBox.Location = new System.Drawing.Point(64, 159);
            this.creditAccBox.Name = "creditAccBox";
            this.creditAccBox.Size = new System.Drawing.Size(304, 340);
            this.creditAccBox.TabIndex = 2;
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
            // DebtText
            // 
            this.DebtText.AutoSize = true;
            this.DebtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtText.Location = new System.Drawing.Point(483, 127);
            this.DebtText.Name = "DebtText";
            this.DebtText.Size = new System.Drawing.Size(88, 32);
            this.DebtText.TabIndex = 4;
            this.DebtText.Text = "Debts";
            // 
            // debtAccBox
            // 
            this.debtAccBox.FormattingEnabled = true;
            this.debtAccBox.ItemHeight = 16;
            this.debtAccBox.Location = new System.Drawing.Point(489, 159);
            this.debtAccBox.Name = "debtAccBox";
            this.debtAccBox.Size = new System.Drawing.Size(304, 340);
            this.debtAccBox.TabIndex = 5;
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
            // transHistBox
            // 
            this.transHistBox.FormattingEnabled = true;
            this.transHistBox.ItemHeight = 16;
            this.transHistBox.Location = new System.Drawing.Point(888, 159);
            this.transHistBox.Name = "transHistBox";
            this.transHistBox.Size = new System.Drawing.Size(304, 340);
            this.transHistBox.TabIndex = 7;
            // 
            // debtAccButton
            // 
            this.debtAccButton.Location = new System.Drawing.Point(752, 122);
            this.debtAccButton.Name = "debtAccButton";
            this.debtAccButton.Size = new System.Drawing.Size(41, 31);
            this.debtAccButton.TabIndex = 8;
            this.debtAccButton.Text = "+";
            this.debtAccButton.UseVisualStyleBackColor = true;
            // 
            // transAddButton
            // 
            this.transAddButton.Location = new System.Drawing.Point(1151, 122);
            this.transAddButton.Name = "transAddButton";
            this.transAddButton.Size = new System.Drawing.Size(41, 31);
            this.transAddButton.TabIndex = 9;
            this.transAddButton.Text = "+";
            this.transAddButton.UseVisualStyleBackColor = true;
            // 
            // includeDebtOption
            // 
            this.includeDebtOption.AutoSize = true;
            this.includeDebtOption.Location = new System.Drawing.Point(576, 85);
            this.includeDebtOption.Name = "includeDebtOption";
            this.includeDebtOption.Size = new System.Drawing.Size(111, 20);
            this.includeDebtOption.TabIndex = 10;
            this.includeDebtOption.Text = "Include Debts";
            this.includeDebtOption.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1225, 528);
            this.Controls.Add(this.includeDebtOption);
            this.Controls.Add(this.transAddButton);
            this.Controls.Add(this.debtAccButton);
            this.Controls.Add(this.transHistBox);
            this.Controls.Add(this.transHistText);
            this.Controls.Add(this.debtAccBox);
            this.Controls.Add(this.DebtText);
            this.Controls.Add(this.addAccButton);
            this.Controls.Add(this.creditAccBox);
            this.Controls.Add(this.AccountsText);
            this.Controls.Add(this.cashTotal);
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
        private System.Windows.Forms.Label AccountsText;
        private System.Windows.Forms.ListBox creditAccBox;
        private System.Windows.Forms.Button addAccButton;
        private System.Windows.Forms.Label DebtText;
        private System.Windows.Forms.ListBox debtAccBox;
        private System.Windows.Forms.Label transHistText;
        private System.Windows.Forms.ListBox transHistBox;
        private System.Windows.Forms.Button debtAccButton;
        private System.Windows.Forms.Button transAddButton;
        private System.Windows.Forms.CheckBox includeDebtOption;
    }
}

