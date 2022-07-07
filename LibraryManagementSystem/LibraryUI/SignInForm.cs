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

        public UserModel LoggedUser { get; set; }

        /// <summary>
        /// Initializes a new instance of the SignInForm class.
        /// </summary>
        public SignInForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the login and password form text boxes, if they are correct, set the LoggedUser property and close the form.
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                UserModel u1 = new UserModel(loginText.Text, passwordText.Text);

                UserModel u2 = GlobalConfig.Connection.ValidUser(u1);
                
                if(u2 != null) {

                    LoggedUser = u2;

                    loginText.Text = "";
                    passwordText.Text = "";

                    this.Close();
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

        /// <summary>
        /// Validates whether text box is filled correctly.
        /// </summary>
        /// <returns>True if text box is filled correctly, false if not.</returns>
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

        /// <summary>
        /// Initializes a new instance of the SignInForm class.
        /// </summary>
        private void signUpButton_Click(object sender, EventArgs e) {

            SignUpForm frm = new SignUpForm();

            frm.Show();
        }
    }
}
