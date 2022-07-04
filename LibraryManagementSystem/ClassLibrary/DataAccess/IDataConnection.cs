using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DataAccess {
    public interface IDataConnection {

        void CreateUser(UserModel user);

        UserModel ValidUser(UserModel user);

        List<BookModel> GetUserBooks(UserModel user);

        void UpdateUser(UserModel user);

        void UpdateBook(BookModel book);
    }
}
