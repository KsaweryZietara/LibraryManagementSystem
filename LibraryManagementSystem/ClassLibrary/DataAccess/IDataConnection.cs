﻿using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DataAccess {
    public interface IDataConnection {

        void CreateUser(UserModel user);

        UserModel ValidUser(UserModel user);

        List<BookModel> GetUserBooks(UserModel user);

        void UpdateBook(BookModel book);

        List<BookModel> GetAvailableBooks();

        List<BookModel> GetBooks();

        void DeleteBook(BookModel book);

        List<UserModel> GetUsers();

        void CreateBook(BookModel book);
    }
}
