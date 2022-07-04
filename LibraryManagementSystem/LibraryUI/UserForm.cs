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
                bookStrings.Add($"{b.Title} {b.Author} {b.Category}");
            }

            booksListBox.DataSource = bookStrings;
        }

        private void returnButton_Click(object sender, EventArgs e) {

            int indexOfSelected = booksListBox.SelectedIndex;



        }
    }
}
