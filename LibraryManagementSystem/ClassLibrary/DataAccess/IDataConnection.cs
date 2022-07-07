using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DataAccess {
    public interface IDataConnection {
        
        /// <summary>
        /// Saves user model to database if it is possible.
        /// </summary>
        /// <param name="user">User model.</param>
        void CreateUser(UserModel user);

        /// <summary>
        /// Checks if user with passed login and password exist.  
        /// </summary>
        /// <param name="user">User model.</param>
        /// <returns>User model if the user exist or null, if not.</returns>
        UserModel ValidUser(UserModel user);

        /// <summary>
        /// Returns the books models which matches the indexes of the user's books indexes.
        /// </summary>
        /// <param name="user">User model.</param>
        /// <returns>List of the user books models which satisfied the condition.</returns>
        List<BookModel> GetUserBooks(UserModel user);

        /// <summary>
        /// Updates the book model.
        /// </summary>
        /// <param name="book">Book model with new parameters.</param>
        void UpdateBook(BookModel book);

        /// <summary>
        /// Returns all books models with null owner.
        /// </summary>
        /// <returns>List of books models with null owner.</returns>
        List<BookModel> GetAvailableBooks();

        /// <summary>
        /// Returns all books models from database.
        /// </summary>
        /// <returns>List of all books models from database.</returns>
        List<BookModel> GetBooks();

        /// <summary>
        /// Deletes from data base passed book model.
        /// </summary>
        /// <param name="book">Book model to removal.</param>
        void DeleteBook(BookModel book);

        /// <summary>
        /// Returns all users models from database.
        /// </summary>
        /// <returns>List of all users models from database.</returns>
        List<UserModel> GetUsers();

        /// <summary>
        /// Saves new book model to database.
        /// </summary>
        /// <param name="book">Book model which will be saved.</param>
        void CreateBook(BookModel book);
    }
}
