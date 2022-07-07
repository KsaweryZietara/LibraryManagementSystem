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

        /// <summary>
        /// Initializes a new instance of the AdminForm class.
        /// </summary>
        public AdminForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes list of books models and users models, refresh the list box.
        /// </summary>
        private void AdminForm_Load(object sender, EventArgs e) {
            
            Books = GlobalConfig.Connection.GetBooks();

            Users = GlobalConfig.Connection.GetUsers(); 

            RefreshListBox();
        }

        /// <summary>
        /// Refresh the form list box with books models.
        /// </summary>
        private void RefreshListBox() {

            booksListBox.DataSource = null;

            List<string> bookStrings = new List<string>();

            foreach (BookModel b in Books) {

                string available = b.Owner != null ? "Not Available" : "Available";

                bookStrings.Add($"{b.Id}  {b.Title}  {b.Author}  {b.Category}  {available}  {b.Owner}");

            }

            booksListBox.DataSource = bookStrings;
        }

        /// <summary>
        /// Delete the selected book from list and database, refresh the list box.
        /// </summary>
        private void deleteBookButton_Click(object sender, EventArgs e) {
            
            if (Books.Count > 0) {

                int indexOfSelected = booksListBox.SelectedIndex;

                GlobalConfig.Connection.DeleteBook(Books[indexOfSelected]);

                Books.RemoveAll(x => x.Id == Books[indexOfSelected].Id);

                RefreshListBox();
            }
        }

        /// <summary>
        /// Initializes a new instance of the NewBookForm class, 
        /// updates the list of books models and refresh the 
        /// list box with books models. 
        /// </summary>
        private void addNewBookButton_Click(object sender, EventArgs e) {
            
            NewBookForm frm = new NewBookForm();

            frm.ShowDialog();

            Books = GlobalConfig.Connection.GetBooks();

            RefreshListBox();
        }
    }
}
