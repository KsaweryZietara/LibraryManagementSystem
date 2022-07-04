﻿using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary.DataAccess {
    public class TextFileConnector : IDataConnection {

        private const string UsersFile = "UsersFile.csv";

        private const string Books = "Books.csv";

        /// <summary>
        /// Saves user model to the text file if it is possible.
        /// </summary>
        /// <param name="user">User model.</param>
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

        /// <summary>
        /// Checks if user with passed login and password exist.  
        /// </summary>
        /// <param name="user">User model.</param>
        /// <returns>User model if the user exist or null, if not.</returns>
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

        /// <summary>
        /// Returns the books models which matches the indexes of the user's books indexes.
        /// </summary>
        /// <param name="user">User model.</param>
        /// <returns>List of the user books models which satisfied the condition.</returns>
        public List<BookModel> GetUserBooks(UserModel user) {

            List<BookModel> books = Books.FullFilePath().LoadFile().ConvertToBookModels();

            List<BookModel> userBooks = books.Where(x => user.BooksId.Any(y => y == x.Id)).ToList();

            return userBooks;
        }
    }
}
