using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form1 loginForm;

        public Form2(Form1 loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseThisForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate account details
            if (usernameInput.Text.Equals("") || passwordInput.Text.Equals(""))
            {
                MessageBox.Show("Username and password cannot be empty. Please try again.");
            }
            else
            {
                //check for existing username
                if (loginForm.acc.FindUserAccount(usernameInput.Text) != null)
                {
                    MessageBox.Show("Username already exists. Please try again.");
                }
                else
                {
                    //register new account
                    Account newAccount = new Account(usernameInput.Text, passwordInput.Text);
                    loginForm.acc.AddAccount(newAccount);
                    MessageBox.Show("New account created. \nPlease log in with your new credentials.");
                    CloseThisForm();
                }
            }
            
        }

        private void CloseThisForm()
        {
            this.Close();
            loginForm.Show();
        }
    }
}
