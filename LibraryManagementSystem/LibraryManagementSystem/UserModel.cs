using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem {
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
        /// Represents books which user borrowed.
        /// </summary>
        public List<BookModel> Books { get; set; } = new List<BookModel>();
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
    }
}
