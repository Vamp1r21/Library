using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryV2._0
{

    public delegate void BookFieldVisitor(string info);
    public delegate string BookFieldSelector(Book book,string info);

    public class Library
    {
        List<Book> _books = new List<Book>();

       
        public Library()
        {
            var file = File.ReadAllLines("../../Folder/library.txt");
            string[] decemetional = { " ", "  ", "\t" };

            foreach (string fileElement in file)
            {
                string[] mas = fileElement.Split(decemetional, StringSplitOptions.RemoveEmptyEntries);
                _books.Add(new Book(mas[0], mas[1], int.Parse(mas[2])));
            }
        }

        public void AcceptMore(BookFieldVisitor visitor, BookFieldSelector selector, string info)
        {
            foreach (Book book in _books)
            {
                visitor(selector(book, info));
            }
        }
    }
}
