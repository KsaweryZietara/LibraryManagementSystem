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
    public partial class NewBookForm : Form {

        public string[] Categories = new string[] { "art",
            "biography",
            "fantasy",
            "fiction",
            "historical",
            "horror",
            "mystery",
            "romance",
            "science"};

        /// <summary>
        /// Initializes a new instance of the NewBookForm class.
        /// </summary>
        public NewBookForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Creates book model with parameters from text boxes and close the form.
        /// </summary>
        private void createButton_Click(object sender, EventArgs e) {
            
            if (ValidateForm()) {

                BookModel model = new BookModel(titleText.Text, authorText.Text, categoryComboBox.Text);

                GlobalConfig.Connection.CreateBook(model);

                this.Close();
            }
            else {
                string message = "Incorrect data.";
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

            if(titleText.Text.Length == 0) {
                output = false;
            }

            if(authorText.Text.Length == 0) {
                output = false;
            }

            return output;
        }

        /// <summary>
        /// Initializes the combo box with parameters from array of strings.
        /// </summary>
        private void NewBookForm_Load(object sender, EventArgs e) {

            List<string> categoryStrings = new List<string>();

            foreach (string s in Categories) {

                categoryStrings.Add(s);

            }

            categoryComboBox.DataSource = categoryStrings;
        }
    }
}
