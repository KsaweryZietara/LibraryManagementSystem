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
    public partial class UserForm : Form {

        public UserModel LoggedUser { get; set; }

        public List<BookModel> UserBooks { get; set; } = new List<BookModel>();

        public UserForm() {

            InitializeComponent();

        }

        private void UserForm_Load(object sender, EventArgs e) {
            
            UserBooks = GlobalConfig.Connection.GetUserBooks(LoggedUser);

            List<string> bookStrings = new List<string>();

            foreach (BookModel b in UserBooks) {
                if (b.Owner == LoggedUser.Login) {
                    bookStrings.Add($"{b.Title} {b.Author} {b.Category}");
                }
            }

            booksListBox.DataSource = bookStrings;
        }

        private void returnButton_Click(object sender, EventArgs e) {

            if (UserBooks.Count > 0) {

                int indexOfSelected = booksListBox.SelectedIndex;

                LoggedUser.BooksId.RemoveAll(x => x == UserBooks[indexOfSelected].Id);

                GlobalConfig.Connection.UpdateUser(LoggedUser);

                UserBooks[indexOfSelected].IsBorrowed = false;
                UserBooks[indexOfSelected].Owner = "---";

                GlobalConfig.Connection.UpdateBook(UserBooks[indexOfSelected]);

                UserBooks.RemoveAll(x => x.Id == UserBooks[indexOfSelected].Id);

                booksListBox.DataSource = null;

                List<string> bookStrings = new List<string>();

                foreach (BookModel b in UserBooks) {
                    if (b.Owner == LoggedUser.Login) {
                        bookStrings.Add($"{b.Title} {b.Author} {b.Category}");
                    }
                }

                booksListBox.DataSource = bookStrings;
            }
            else {
                string message = "You don't have books.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e) {

        }
    }
}
