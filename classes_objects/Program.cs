using System;


namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book("zach");
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            //Book book2 = new Book("john");
            //book1.title = "book2";
            //book1.author = "autho2";
            //book1.pages = 500;

            Book book1 = new Book("title1", "author1", 300);
            Book book2 = new Book("title2", "author2", 301);

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            book2.title = "hobbit";
            Console.WriteLine(book2.title);

            Student student1 = new Student("zach", "econ", 3.7);
            Student student2 = new Student("john", "psych", 3.2);

            //METHODS
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            //GETTERS AND SETTERS
            Movie avengers = new Movie("avengers", "director1", "PG-13");
            Movie ratingTest = new Movie("avengers", "director1", "Dog");
            Movie shrek = new Movie("shrek", "director2", "PG");

            //Console.WriteLine(avengers.rating);//error bc rating attr is inaccessible since we defined it as private
            Console.WriteLine(avengers.Rating);
            avengers.Rating = "R";
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(ratingTest.Rating);

            //STATIC ATTRIBUTES
            Song holiday = new Song("song1", "artist1", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("song2", "artist2", 201);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());

            //STATIC METHODS
            UsefulTools.SayHi("Zach");

            //INHERITANCE
            Chef chef = new Chef();
            chef.MakeChicken();
            Chef2 chef2 = new Chef2();
            chef2.MakeChicken();
            chef2.MakePasta();
            chef.MakeSpecialDish();
            chef2.MakeSpecialDish();
        }
    }
}