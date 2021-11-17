using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {
        Book book1 = new Book(); // we created the Book class in separate file with attributes title, author, and pages

        book1.title = "Harry Potter";
        book1.author = "JK Rowling";
        book1.pages = 400;

        Console.WriteLine(book1.title);
    }
  }
}