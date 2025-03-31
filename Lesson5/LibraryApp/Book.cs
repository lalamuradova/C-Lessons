using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {

        public static int Id { get; private set; } = 0;
        private string _id;
        private string _title;
        private string _author;
        private string _genre;
        private string _year;

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Kitabın adı boş ola bilməz.");
                }
                _title = value;
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Yazıçı adı boş ola bilməz.");
                }
                _author = value;
            }
        }
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Janr adı boş ola bilməz.");
                }
                _genre = value;
            }
        }
        public string Year
        {
            get { return _year; }
            set
            {
                int parsedYear;
                if (!int.TryParse(value, out parsedYear) || parsedYear <= 0)
                {
                    throw new ArgumentException("Il boş və ya sıfırdana az ola bilməz.");
                }
                _year = value;
            }
        }
        public Book()
        {
            Id++;
            ID = Id.ToString();
            Title = "None";
            Author = "None";
            Genre = "None";
            Year = "2025";
        }
        public Book(string title,string author,string genre, string year)
        {
            Id++;
            ID = Id.ToString();
            Title = title ; 
            Author = author ; 
            Genre = genre ;   
            Year = year ;
        }
    }
}
