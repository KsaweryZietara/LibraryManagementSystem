using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary.DataAccess {
    public class TextFileConnector : IDataConnection {

        private const string UsersFile = "UsersFile.csv";

        private const string BooksFile = "BooksFile.csv";

        
        public void CreateUser(UserModel user) {

            List<UserModel> users = UsersFile.FullFilePath().LoadFile().ConvertToUserModels();

            bool alreadyUsedEmail = users.Any(x => x.EmailAddress == user.EmailAddress || x.Login == user.Login);

            if (alreadyUsedEmail) {
                string message = "E-mail or Login is already taken.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else {
                users.Add(user);
                users.SaveToUserFile(UsersFile);
            }
        }

        
        public UserModel ValidUser(UserModel user) {

            List<UserModel> users = UsersFile.FullFilePath().LoadFile().ConvertToUserModels();

            UserModel u = null;

            int index = users.FindIndex(x => x.Login == user.Login);

            if (index > -1) {
                if (user.Password.CheckPassword(users[index].Password)) {
                    u = users[index];
                }

            }

            return u;
        } 

        
        public List<BookModel> GetUserBooks(UserModel user) {

            List<BookModel> books = BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            List<BookModel> userBooks = books.Where(x => x.Owner == user.Login).ToList();

            return userBooks;
        }

        public void UpdateBook(BookModel book) {

            List<BookModel> books = BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            int indexOfUser = books.FindIndex(x => x.Id == book.Id);

            books[indexOfUser] = book;

            books.SaveToBookFile(BooksFile);
        }

        public List<BookModel> GetAvailableBooks() {

            List<BookModel> books = BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            var output = books.Where(x => x.Owner == null).ToList();

            return output;
        }

        public List<BookModel> GetBooks() {
            return BooksFile.FullFilePath().LoadFile().ConvertToBookModels();
        }

        public void DeleteBook(BookModel book) {

            List<BookModel> books = GetBooks();

            books.RemoveAll(x => x.Id == book.Id);

            books.SaveToBookFile(BooksFile);
        }

        public List<UserModel> GetUsers() {
            return UsersFile.FullFilePath().LoadFile().ConvertToUserModels();
        }

        public void CreateBook(BookModel book) {

            List<BookModel> books = BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            int highestIndex = books.Max(x => x.Id);

            book.Id = highestIndex + 1;

            book.Owner = null;

            books.Add(book);

            books.SaveToBookFile(BooksFile);
        }
    }
}
