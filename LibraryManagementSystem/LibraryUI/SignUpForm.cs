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
    public partial class SignUpForm : Form {
        public SignUpForm() {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                UserModel model = new UserModel(loginText.Text,
                    passwordText.Text.PasswordHashing(),      
                    firstNameText.Text,
                    lastNameText.Text,
                    phoneNumberText.Text,
                    emailText.Text); 

                GlobalConfig.Connection.CreateUser(model);

                this.Close();
            }
            else {
                string message = "Incorrect data.";
                string title = "Error";
                MessageBox.Show(message, title);
            }

        }
        private bool ValidateForm() {

            bool output = true;

            if (firstNameText.Text.Length == 0) {
                output = false;
            }

            if (firstNameText.Text.Any(char.IsDigit)) {
                output = false;
            }

            if (lastNameText.Text.Length == 0) {
                output = false;
            }

            if (lastNameText.Text.Any(char.IsDigit)) {
                output = false;
            }

            if (phoneNumberText.Text.Length != 9) {
                output = false;
            }

            if (phoneNumberText.Text.Any(x => char.IsLetter(x))) {
                output = false;
            }

            if (emailText.Text.Length == 0) {
                output = false;
            }

            int indexOfAt = emailText.Text.IndexOf('@');
            int indexOfDot = emailText.Text.IndexOf('.');

            if (indexOfAt < 0 || indexOfDot < 0) {
                output = false;
            }

            if (indexOfAt > indexOfDot) {
                output = false;
            }

            if (indexOfDot > emailText.Text.Length-4) {
                output = false;
            }

            if (loginText.Text.Length == 0) {
                output = false;
            }

            if (passwordText.Text.Length == 0) {
                output = false;
            }

            return output;
        }

        
    }
}
