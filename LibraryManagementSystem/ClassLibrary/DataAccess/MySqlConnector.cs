using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using Dapper;

namespace ClassLibrary.DataAccess {
    class MySqlConnector : IDataConnection {

        private string myConnectionString = "server=localhost;database=librarymanagementsystem;uid=root;pwd=password;";

        public void CreateBook(BookModel book) {

            try {
                book.Owner = null;

                MySqlConnection connection = new MySqlConnection(myConnectionString);

                string sqlQuery = "INSERT INTO books(Title, Author, Category) VALUES(@Title, @Author, @Category)";

                var rowsAffected = connection.Execute(sqlQuery, book);
                
            }
            catch {

            }

        }

        public void CreateUser(UserModel user) {

            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand();
            
            try {

                connection.Open();

                command.Connection = connection;
                command.CommandText = "insert_user";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("p_Login", user.Login);
                command.Parameters["p_Login"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("p_Password", user.Password);
                command.Parameters["p_Password"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("p_FirstName", user.FirstName);
                command.Parameters["p_FirstName"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("p_LastName", user.LastName);
                command.Parameters["p_LastName"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("p_PhoneNumber", user.PhoneNumber);
                command.Parameters["p_PhoneNumber"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("p_EmailAddress", user.EmailAddress);
                command.Parameters["p_EmailAddress"].Direction = ParameterDirection.Input;

                command.ExecuteNonQuery();
            }
            catch {
                string message = "E-mail or Login is already taken.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            connection.Close();
        }

        public List<BookModel> GetAvailableBooks() {
            
            try {
                MySqlConnection connection = new MySqlConnection(myConnectionString);

                var result = connection.Query<BookModel>("get_available_books",
                        commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
            catch {
                return null;
            }
        }

        public List<BookModel> GetBooks() {
            
            try {
                MySqlConnection connection = new MySqlConnection(myConnectionString);

                var result = connection.Query<BookModel>("get_books",
                        commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
            catch {
                return null;
            }
        }

        public List<BookModel> GetUserBooks(UserModel user) {

            try {
                MySqlConnection connection = new MySqlConnection(myConnectionString);

                var result = connection.Query<BookModel>("get_user_books",
                        new { p_Owner = user.Login },
                        commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
            catch {
                return null;
            }
        }

        public List<UserModel> GetUsers() {
            
            try {
                MySqlConnection connection = new MySqlConnection(myConnectionString);

                var result = connection.Query<UserModel>("get_users",
                        commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
            catch {
                return null;
            }
        }

        public void UpdateBook(BookModel book) {

            try {
                MySqlConnection connection = new MySqlConnection(myConnectionString);

                string sql = "UPDATE Books SET Title = @Title, Author = @Author, Category = @Category, Owner = @Owner WHERE Id = @Id;";

                var rowsAffected = connection.Execute(sql, new { Id = book.Id, Title = book.Title, Author = book.Author, Category = book.Category, Owner = book.Owner });
            }
            catch {

            }
        }

        public void DeleteBook(BookModel book) {

            try {
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                
                string sql = "DELETE FROM books WHERE Id = @Id;";

                var rowsAffected = connection.Execute(sql, new { Id = book.Id });
            }
            catch {

            }
        }

        public UserModel ValidUser(UserModel user) {
            
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try {

                var result = connection.Query<UserModel>("valid_user", 
                    new { p_Login = user.Login }, 
                    commandType: CommandType.StoredProcedure).First();

                UserModel u = null;

                if (user.Password.CheckPassword(result.Password)) {
                    u = result;
                }

                return u;

            }
            catch {
                return null;
            }
        }
    }
}
