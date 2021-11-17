using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book() { }
        public Book(string aTitle, string aAuthor, int aPages)//public + name of class indicates it's a constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}