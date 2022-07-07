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
    public partial class AllBooksForm : Form {

        public UserModel LoggedUser { get; set; }

        public List<BookModel> Books { get; set; } = new List<BookModel>();

        /// <summary>
        /// Initializes a new instance of the AllBooksForm class.
        /// </summary>
        public AllBooksForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes list of books models and refresh the list box.
        /// </summary>
        private void AllBooksForm_Load(object sender, EventArgs e) {

            Books = GlobalConfig.Connection.GetAvailableBooks();

            RefreshListBox(); 
        }

        /// <summary>
        /// Validates whether text box is filled correctly.
        /// </summary>
        /// <returns>True if text box is filled correctly, false if not.</returns>
        private bool ValidateForm() {

            bool output = true;

            if(keyWordText.Text.Length == 0) {
                output = false;
            }

            return output;
        }

        /// <summary>
        /// Fills list with books models which match the text, from text box, refresh the list box.
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                List<BookModel> l = new List<BookModel>();
                List<BookModel> k = Books;

                foreach (BookModel b in k) {
                    if(b.Title.ToLower().Contains(keyWordText.Text.ToLower()) || b.Author.ToLower().Contains(keyWordText.Text.ToLower())) {
                        l.Add(b);
                    }
                }

                Books = l;

                RefreshListBox();
            }
        }

        /// <summary>
        /// Refresh the form list box with books models.
        /// </summary>
        private void RefreshListBox() {

            booksListBox.DataSource = null;

            List<string> bookStrings = new List<string>();

            foreach (BookModel b in Books) {

                bookStrings.Add($"{b.Title}  {b.Author}  {b.Category}");

            }

            booksListBox.DataSource = bookStrings;
        }

        /// <summary>
        /// Clears the text box, initializes list of books models and refresh the list box.
        /// </summary>
        private void showAllBooksButton_Click(object sender, EventArgs e) {

            keyWordText.Text = "";

            Books = GlobalConfig.Connection.GetAvailableBooks();

            RefreshListBox();
        }

        /// <summary>
        /// Updates the owner of the book and refresh the list box.
        /// </summary>
        private void borrowButton_Click(object sender, EventArgs e) {

            if (Books.Count > 0) {
                
                int indexOfSelected = booksListBox.SelectedIndex;

                Books[indexOfSelected].Owner = LoggedUser.Login;

                GlobalConfig.Connection.UpdateBook(Books[indexOfSelected]);

                Books.RemoveAll(x => x.Id == Books[indexOfSelected].Id);

                RefreshListBox();

                
            }
        }
    }
}
