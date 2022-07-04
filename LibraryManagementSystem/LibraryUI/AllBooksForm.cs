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

        public AllBooksForm() {
            InitializeComponent();
        }

        private void AllBooksForm_Load(object sender, EventArgs e) {

            Books = GlobalConfig.Connection.GetAvailableBooks();

            RefreshListBox(); 
        }

        private bool ValidateForm() {

            bool output = true;

            if(keyWordText.Text.Length == 0) {
                output = false;
            }

            return output;
        }

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

        private void RefreshListBox() {

            booksListBox.DataSource = null;

            List<string> bookStrings = new List<string>();

            foreach (BookModel b in Books) {

                bookStrings.Add($"{b.Title}  {b.Author}  {b.Category}");

            }

            booksListBox.DataSource = bookStrings;
        }

        private void showAllBooksButton_Click(object sender, EventArgs e) {

            keyWordText.Text = "";

            Books = GlobalConfig.Connection.GetAvailableBooks();

            RefreshListBox();
        }

        private void borrowButton_Click(object sender, EventArgs e) {

            if (Books.Count > 0) {
                
                int indexOfSelected = booksListBox.SelectedIndex;

                LoggedUser.BooksId.Add(Books[indexOfSelected].Id);

                GlobalConfig.Connection.UpdateUser(LoggedUser);

                Books[indexOfSelected].IsBorrowed = true;
                Books[indexOfSelected].Owner = LoggedUser.Login;

                GlobalConfig.Connection.UpdateBook(Books[indexOfSelected]);

                Books.RemoveAll(x => x.Id == Books[indexOfSelected].Id);

                RefreshListBox();

                
            }
        }
    }
}
