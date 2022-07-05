using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models {
    public class UserModel {

        /// <summary>
        /// Represents user login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Represents user password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Represents user first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents user last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents user telephone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Represents user email address.
        /// </summary>
        public string EmailAddress { get; set; }

        public UserModel() {

        }

        public UserModel(string login, string password) {
            Login = login;
            Password = password;
        }

        public UserModel(string login, string password, string firstName, string lastName, string phoneNumber, string emailAddress) {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }
    }
}
