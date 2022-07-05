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

        public NewBookForm() {
            InitializeComponent();
        }

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

        private void NewBookForm_Load(object sender, EventArgs e) {

            List<string> categoryStrings = new List<string>();

            foreach (string s in Categories) {

                categoryStrings.Add(s);

            }

            categoryComboBox.DataSource = categoryStrings;
        }
    }
}
