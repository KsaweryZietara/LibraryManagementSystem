using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models {
    public class BookModel {

        /// <summary>
        /// Represents book id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Represents author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Represents category of the book.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Represents who borrowed the book.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Initializes a new instance of the BookModel class.
        /// </summary>
        public BookModel() {
        }

        /// <summary>
        /// /// <summary>
        /// Initializes a new instance of the BookModel class.
        /// </summary>
        /// </summary>
        /// <param name="title">Title of the book.</param>
        /// <param name="author">Author of the book.</param>
        /// <param name="category">Category of the book.</param>
        public BookModel(string title, string author, string category) {
            Title = title;
            Author = author;
            Category = category;
        }
    }
}
