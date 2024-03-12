using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryV2._0
{
    public class Book
    {
        string _author;
        string _title;
        int _publishYear;

        public Book(string author, string title, int publisherYear)
        {
            _author = author;
            _title = title;
            _publishYear = publisherYear;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public int GetPublishYear()
        {
            return _publishYear;
        }
    }
}
