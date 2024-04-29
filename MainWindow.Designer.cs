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
            this.finishButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashTotal
            // 
            this.cashTotal.AutoSize = true;
            this.cashTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTotal.Location = new System.Drawing.Point(568, 36);
            this.cashTotal.Name = "cashTotal";
            this.cashTotal.Size = new System.Drawing.Size(119, 46);
            this.cashTotal.TabIndex = 1;
            this.cashTotal.Text = "$0.00";
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
            this.includeDebtOption.Location = new System.Drawing.Point(576, 85);
            this.includeDebtOption.Name = "includeDebtOption";
            this.includeDebtOption.Size = new System.Drawing.Size(111, 20);
            this.includeDebtOption.TabIndex = 10;
            this.includeDebtOption.Text = "Include Debts";
            this.includeDebtOption.UseVisualStyleBackColor = true;
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
            this.newDebtText.Location = new System.Drawing.Point(537, 36);
            this.newDebtText.Name = "newDebtText";
            this.newDebtText.Size = new System.Drawing.Size(195, 46);
            this.newDebtText.TabIndex = 11;
            this.newDebtText.Text = "New Debt";
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
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(459, 475);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(128, 35);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Add";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(635, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 33);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1225, 528);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finishButton);
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
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

