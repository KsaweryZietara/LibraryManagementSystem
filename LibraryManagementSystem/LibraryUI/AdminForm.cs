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
    public partial class AdminForm : Form {

        public List<BookModel> Books { get; set; } = new List<BookModel>();

        public List<UserModel> Users { get; set; } = new List<UserModel>();

        public AdminForm() {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            
            Books = GlobalConfig.Connection.GetBooks();

            Users = GlobalConfig.Connection.GetUsers(); 

            RefreshListBox();
        }

        private void RefreshListBox() {

            booksListBox.DataSource = null;

            List<string> bookStrings = new List<string>();

            foreach (BookModel b in Books) {

                string available = b.IsBorrowed ? "Not Available" : "Available";

                bookStrings.Add($"{b.Id}  {b.Title}  {b.Author}  {b.Category}  {available}  {b.Owner}");

            }

            booksListBox.DataSource = bookStrings;
        }

        private void deleteBookButton_Click(object sender, EventArgs e) {
            
            if (Books.Count > 0) {

                int indexOfSelected = booksListBox.SelectedIndex;

                int indexOfUser = Users.FindIndex(x => x.Login == Books[indexOfSelected].Owner);

                Users[indexOfUser].BooksId.RemoveAll(x => x == Books[indexOfSelected].Id);

                GlobalConfig.Connection.UpdateUser(Users[indexOfUser]);

                Books.RemoveAll(x => x.Id == Books[indexOfSelected].Id);

                GlobalConfig.Connection.UpdateListOfBooks(Books);

                RefreshListBox();
            }
        }

        private void addNewBookButton_Click(object sender, EventArgs e) {
            
            NewBookForm frm = new NewBookForm();

            frm.ShowDialog();

            Books = GlobalConfig.Connection.GetBooks();

            RefreshListBox();
        }
    }
}
