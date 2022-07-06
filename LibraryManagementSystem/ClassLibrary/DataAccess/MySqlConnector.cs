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
            throw new NotImplementedException();
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
            catch(MySqlException ex) {
                string message = "E-mail or Login is already taken.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            connection.Close();
        }

        public List<BookModel> GetAvailableBooks() {
            throw new NotImplementedException();
        }

        public List<BookModel> GetBooks() {
            throw new NotImplementedException();
        }

        public List<BookModel> GetUserBooks(UserModel user) {

            MySqlConnection connection = new MySqlConnection(myConnectionString);

            var result = connection.Query<BookModel>("get_user_books",
                    new { p_Owner = user.Login },
                    commandType: CommandType.StoredProcedure).ToList();

            return result;
        }

        public List<UserModel> GetUsers() {
            throw new NotImplementedException();
        }

        public void UpdateBook(BookModel book) {
            throw new NotImplementedException();
        }

        public void UpdateListOfBooks(List<BookModel> list) {
            throw new NotImplementedException();
        }

        public UserModel ValidUser(UserModel user) {
            
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try {

                var result = connection.Query<UserModel>("valid_user", 
                    new { p_Login = user.Login }, 
                    commandType: CommandType.StoredProcedure).ToList();

                UserModel u = null;

                if (result.Count == 0) {
                    return u;
                }

                if (user.Password.CheckPassword(result.First().Password)) {
                    u = result.First();
                }

                return u;

            }
            catch (MySqlException ex) {
                string message = "E-mail or Login is already taken.";
                string title = "Error";
                MessageBox.Show(message, title);
            }

            return null;
        }
    }
}
