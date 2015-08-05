using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPOS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }


            if (txtUserName.Text == "admin" && txtPassword.Text == "12345")
            {
                //MessageBox.Show("Successfully Logged In");
                this.Hide();
                Form1 f1 = new Form1();
                f1.label1Text = "User: Admin";
                f1.FormClosed += (s,args) => this.Close();
                f1.Show();

                return;
            }
            else
            {
                MessageBox.Show("Please enter correct username and password.");
                return;
            }
        }
    }
}
