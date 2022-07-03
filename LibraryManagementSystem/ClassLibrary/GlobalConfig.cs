using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public static class GlobalConfig {
        public static IDataConnection Connection { get; private set; }

        public static UserModel LoggedUser { get; private set; }

        /// <summary>
        /// Function initialize type of the data connection for the app.
        /// </summary>
        /// <param name="e">Enum which represent type of data connection.</param>
        public static void InitializeDataConnection(Enums e) {
            if (e == Enums.textFile) {
                Connection = new TextFileConnector(); 
            }
            
            else if (e == Enums.sql) {

            }
        }

        /// <summary>
        /// Function set passed user as logged user.
        /// </summary>
        /// <param name="user">User model which log in.</param>
        public static void UserLogIn(UserModel user) {
            LoggedUser = user;
        }

        /// <summary>
        /// Function change LoggedUser to null.
        /// </summary>
        public static void UserLogOut() {
            LoggedUser = null;
        }
    }
}
