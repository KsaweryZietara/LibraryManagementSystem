using ClassLibrary;
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
    public partial class SignUpForm : Form {
        public SignUpForm() {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e) {

        }

        private void signUpButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                UserModel model = new UserModel(loginText.Text, 
                    passwordText.Text, 
                    firstNameText.Text, 
                    lastNameText.Text, 
                    phoneNumberText.Text, 
                    emailText.Text);

                //save to text file

            }

        }
        private bool ValidateForm() {

            bool output = true;

            if (firstNameText.Text.Length == 0) {
                output = false;
            }

            if (lastNameText.Text.Length == 0) {
                output = false;
            }

            if (phoneNumberText.Text.Length == 0) {
                output = false;
            }

            if (emailText.Text.Length == 0) {
                output = false;
            }

            if(loginText.Text.Length == 0) {
                output = false;
            }

            if(passwordText.Text.Length == 0) {
                output = false;
            }

            return output;
        }

        
    }
}
