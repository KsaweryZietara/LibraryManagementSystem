using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataAccess {
    public static class TextConnectorProcessor {

        /// <summary>
        /// Adds a path to the file name.
        /// </summary>
        /// <param name="fileName">Name of the text file.</param>
        /// <returns>Text file name with path added.</returns>
        public static string FullFilePath(this string fileName) {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        /// <summary>
        /// Converts content of the text file to a list of strings.
        /// </summary>
        /// <param name="file">Name of the text file.</param>
        /// <returns>List of strings extracted from the text file.</returns>
        public static List<string> LoadFile(this string file) {
            if (!File.Exists(file)) {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// Converts list of string to a list of users models.
        /// </summary>
        /// <param name="lines">List of strings which contains users models.</param>
        /// <returns>List of users models.</returns>
        public static List<UserModel> ConvertToUserModels(this List<string> lines) {

            List<UserModel> output = new List<UserModel>();

            foreach (string line in lines) {

                string[] cols = line.Split(',');
                
                if (cols.Length == 7) {
                    
                    UserModel u = new UserModel();
                    u.Login = cols[0];
                    u.Password = cols[1];

                    u.BooksId = cols[2].Split('|').ToList().Select(s => int.Parse(s)).ToList();

                    u.FirstName = cols[3];
                    u.LastName = cols[4];
                    u.PhoneNumber = cols[5];
                    u.EmailAddress = cols[6];

                    output.Add(u);
                }
            }

            return output;
        }

        /// <summary>
        /// Saves list of users models to the text file.
        /// </summary>
        /// <param name="users">List of users models.</param>
        /// <param name="fileName">Name of the text file.</param>
        public static void SaveToUserFile(this List<UserModel> users, string fileName) {

            List<string> lines = new List<string>();

            foreach (UserModel u in users) {

                string booksId = "";

                foreach (int i in u.BooksId) {
                    booksId += i;
                    booksId += '|';
                }

                booksId = booksId.Substring(0, booksId.Length - 1);

                lines.Add($"{u.Login},{u.Password},{booksId},{u.FirstName},{u.LastName},{u.PhoneNumber},{u.EmailAddress}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /// <summary>
        /// Convert list of string to a list of books models.
        /// </summary>
        /// <param name="lines">List of strings which contains books models.</param>
        /// <returns>List of books models.</returns>
        public static List<BookModel> ConvertToBookModels(this List<string> lines) {

            List<BookModel> output = new List<BookModel>();

            foreach (string line in lines) {

                string[] cols = line.Split(',');

                if (cols.Length == 6) {

                    BookModel b = new BookModel();
                    
                    b.Id = Int32.Parse(cols[0]);
                    b.Title = cols[1];
                    b.Author = cols[2];
                    b.Category = cols[3];
                    
                    if(cols[4] == "true") {
                        b.IsBorrowed = true;
                    }
                    else {
                        b.IsBorrowed = false;
                    }

                    b.Owner = cols[5];
                    
                    output.Add(b);
                }
            }

            return output;
        }

    }
}
