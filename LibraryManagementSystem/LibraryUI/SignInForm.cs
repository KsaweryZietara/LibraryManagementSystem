using ClassLibrary;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI {
    public partial class SignInForm : Form {
        public SignInForm() {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                UserModel u1 = new UserModel(loginText.Text, passwordText.Text);

                UserModel u2 = GlobalConfig.Connection.ValidUser(u1);
                
                if(u2 != null) {

                    this.Hide();

                    loginText.Text = "";
                    passwordText.Text = "";

                    UserForm frm = new UserForm();
                    frm.LoggedUser = u2;
                    frm.Show();

                }
                else {
                    string message = "Invalid login or password.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }

            }
            else {
                string message = "Fill the login and password.";
                string title = "Error";
                MessageBox.Show(message, title);
            }

        }

        private bool ValidateForm() {

            bool output = true;

            if (loginText.Text.Length == 0) {
                output = false;
            }

            if(passwordText.Text.Length == 0) {
                output = false;
            }

            return output;
        }

        private void signUpButton_Click(object sender, EventArgs e) {

            SignUpForm frm = new SignUpForm();

            frm.Show();

            
        }
    }
}
