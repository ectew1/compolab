using System;
//using System.IO;

namespace compolab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;
        // public Book()
        // {

        // }
        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            isbn = tempIsbn;
            title = tempTitle;
            author = tempAuthor;
        }
        public string GetIsbn()
        {
            return isbn;
        }
        public void SetIsbn(string tempIsbn)
        {
            isbn = tempIsbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string tempTitle)
        {
            title = tempTitle;
        }
        public Author GetAuthor()
        {
            return author;
        }
        // public SetAuthor()
        // {
        //     //Author = author;
        // }
        public override string ToString()
        {
            return $"isbn = {this.GetIsbn()}" + $" title = {this.GetTitle()}" + $" {this.author.ToString()}";
        }
    }
}