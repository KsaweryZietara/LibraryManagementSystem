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

        /// <summary>
        /// Initializes a new instance of the UserModel class.
        /// </summary>
        public UserModel() {

        }

        /// <summary>
        /// Initializes a new instance of the UserModel class.
        /// </summary>
        /// <param name="login">Login of the user.</param>
        /// <param name="password">Password of the user.</param>
        public UserModel(string login, string password) {
            Login = login;
            Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the UserModel class.
        /// </summary>
        /// <param name="login">Login of the user.</param>
        /// <param name="password">Password of the user.</param>
        /// <param name="firstName">First name of the user.</param>
        /// <param name="lastName">Last name of the user.</param>
        /// <param name="phoneNumber">Phone number of the user.</param>
        /// <param name="emailAddress">Email address of the user.</param>
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
