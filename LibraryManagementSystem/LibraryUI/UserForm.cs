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

        /// <summary>
        /// Initializes a new instance of the UserForm class.
        /// </summary>
        public UserForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the login label to user login, initializes list of user's books models and refresh the list box.
        /// </summary>
        private void UserForm_Load(object sender, EventArgs e) {

            loginLabel.Text = LoggedUser.Login;

            UserBooks = GlobalConfig.Connection.GetUserBooks(LoggedUser);

            RefreshListBox();
        }

        /// <summary>
        /// Updates the owner of the selected book, remove it from the list and refresh the list box. 
        /// </summary>
        private void returnButton_Click(object sender, EventArgs e) {

            if (UserBooks.Count > 0) {

                int indexOfSelected = booksListBox.SelectedIndex;

                UserBooks[indexOfSelected].Owner = null;

                GlobalConfig.Connection.UpdateBook(UserBooks[indexOfSelected]);

                UserBooks.RemoveAll(x => x.Id == UserBooks[indexOfSelected].Id);

                RefreshListBox();
            }
            else {
                string message = "You don't have books.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AllBooksForm class, updates the user's books models 
        /// and refresh the list box. 
        /// </summary>
        private void borrowButton_Click(object sender, EventArgs e) {
            
            AllBooksForm frm = new AllBooksForm();

            frm.LoggedUser = LoggedUser;

            frm.ShowDialog();

            UserBooks = GlobalConfig.Connection.GetUserBooks(LoggedUser);

            RefreshListBox();
        }

        /// <summary>
        /// Refresh the form list box with books models.
        /// </summary>
        private void RefreshListBox() {
           
            booksListBox.DataSource = null;

            List<string> bookStrings = new List<string>();

            foreach (BookModel b in UserBooks) {
                if (b.Owner == LoggedUser.Login) {
                    bookStrings.Add($"{b.Title}  {b.Author}  {b.Category}");
                }
            }

            booksListBox.DataSource = bookStrings;
        }

    }
}
