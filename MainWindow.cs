using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fTrack
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addAccButton_Click(object sender, EventArgs e)
        {
            this.newAccText.Visible = true;
            this.cancelButton.Visible = true;
            this.finishButton.Visible = true;
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
            this.finishButton.Visible = false;
            this.cancelButton.Visible = false;
        }

        private void addDebtButton_Click(object sender, EventArgs e)
        {
            this.newDebtText.Visible = true;
            disableElems();
        }

        private void addTransButton_Click(object sender, EventArgs e)
        {
            this.newTransText.Visible = true;
            disableElems();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.newAccText.Visible = false;
            returnToMain();
        }
    }
}
