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
    }
}
