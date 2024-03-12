using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryV2._0
{
    public static class BookFieldSelectors
    {

        public static string MoreYear(Book book, string year)
        {
            if (book.GetPublishYear() > int.Parse(year))
            {
                return $"{book.GetAuthor()} {book.GetTitle()} {book.GetPublishYear().ToString()}";
            }
            else
            {
                return "";
            }
        }

        public static string LessYear(Book book, string year)
        {
            if (book.GetPublishYear() < int.Parse(year))
            {
                return $"{book.GetAuthor()} {book.GetTitle()} {book.GetPublishYear().ToString()}";
            }
            else
            {
                return "";
            }
        }

        public static string ContainsInAuthor(Book book, string element)
        {
            if (book.GetAuthor().ToLower().Contains(element.ToLower()))
            {
                return $"{book.GetAuthor()} {book.GetTitle()} {book.GetPublishYear().ToString()}";
            }
            else
            {
                return "";
            }
        }

        public static string ContainsInTitle(Book book, string element)
        {
            if (book.GetTitle().ToLower().Contains(element.ToLower()))
            {
                return $"{book.GetAuthor()} {book.GetTitle()} {book.GetPublishYear().ToString()}";
            }
            else
            {
                return "";
            }
        }
    }
}
