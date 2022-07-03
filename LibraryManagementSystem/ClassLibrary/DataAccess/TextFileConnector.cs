using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary.DataAccess {
    public class TextFileConnector : IDataConnection {

        private const string UsersFile = "UsersFile.csv";

        /// <summary>
        /// Function save user model to the text file if it is possible.
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
        /// Function check if user with input login and password exist.  
        /// </summary>
        /// <param name="user">User model</param>
        /// <returns>User model if the user exist or null, if not.</returns>
        public UserModel UserLogIn(UserModel user) {

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
    }
}
