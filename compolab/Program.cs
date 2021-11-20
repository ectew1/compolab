using System;

namespace compolab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("JK Rowling", 'f', "jkrowling@yahoo.com");
            Console.WriteLine($"\n{myAuthor.ToString()}");

            Book myBook = new Book("35223", "Harry Potter", myAuthor);
            Console.WriteLine($"\n{myBook.ToString()}");

            Console.WriteLine($"\n{myBook.GetAuthor().ToString()}");

            Book yourBook = new Book("71524", "The Killer Angels", new Author("Michael Shaara", 'm', "mshaara1@aol.com"));
            Console.WriteLine($"\n{yourBook.ToString()}");
            yourBook.GetAuthor().SetEmail("mshaara1@comcast.net");
            Console.WriteLine($"{yourBook.ToString()}\n");
        }
    }
}
