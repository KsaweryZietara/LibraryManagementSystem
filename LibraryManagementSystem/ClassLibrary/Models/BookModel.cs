using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models {
    public class BookModel {

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
        /// Represents if the book is borrowed.
        /// </summary>
        public bool IsBorrowed { get; set; }

        /// <summary>
        /// Represents who borrowed the book.
        /// </summary>
        public string Owner { get; set; }
    }
}
