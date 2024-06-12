using _02Uzduotis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02Uzduotis.Models
{
    public class Book: Item, IBorrowable
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(int id, string title, int publicationYear, string author, string genre)
            :base (id, title, publicationYear)
        {
            Author = author;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Author} - {Genre}";
        }

        public void Borrow(Reader reader)
        {
            reader.BorrowItem(this);
        }

        public void Return(Reader reader)
        {
            reader.BorrowedItems.Remove(this);
        }
    }
}
