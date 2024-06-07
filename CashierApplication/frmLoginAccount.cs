using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            
            Cashier cashier = new Cashier("Clarisa Castro", "Finance", "cashier101", "password123");

            if (cashier.validateLogin(username, password))
            {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment());
                this.Hide();
                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
