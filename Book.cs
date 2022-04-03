using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_CSharp
{
    internal class Book
    {
        //Instance Variables(live within a class)
        private string title = "Mathu";
        private string author;
        private int pages;
        private int wordCount;

        //Constructor(same name as the class and don't specify return type)
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        //2nd Constructor
        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        //Method to retrieve the current title for a book
        public string GetTitle()
        {
            return title;
        }

        //specify a new title for the book
        public void SetTitle(string title)
        {
            this.title = title;
        }

        //supplies the text of the book and updates the word count accordingly
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
