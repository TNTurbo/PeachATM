using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeachATM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // I have pre-entered values into all fields, but these would be pulled from a database.
        }

        private void btnDepositCash_Click(object sender, EventArgs e)
        {
            txtFunds.Text = AddFunds(25, int.Parse(txtFunds.Text)).ToString();
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            txtFunds.Text = RemoveFunds(25, int.Parse(txtFunds.Text)).ToString();
        }

        private void btnDepositCheck_Click(object sender, EventArgs e)
        {
            //Prompt User to insert Check
            //Tell user it will take some time for funds to be available. 
            //Wait for ATM to accept Check
            //Send to Mrs. Peach approval team. 
        }

        private void btnGenerateCashierCheck_Click(object sender, EventArgs e)
        {
            txtFunds.Text = RemoveFunds(75, int.Parse(txtFunds.Text)).ToString();
            //Print check for 75 dollars.
        }

        public static int AddFunds(int amount, int funds)
        {
            return (funds + amount);
        }

        public static int RemoveFunds(int amount, int funds)
        {
            return (funds - amount);
        }

        private void btnMockDD_Click(object sender, EventArgs e)
        {
            txtFunds.Text = AddFunds(130, int.Parse(txtFunds.Text)).ToString();
            txtDDStatus.Text = UpdateDDStatus();
        }

        public static string UpdateDDStatus()
        {
            return "Qualified";
        }
    }
}
