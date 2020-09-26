using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    //Create a class called Book with fields like id, title, price, author.
    //Create properties for these fields.
    //Write a program in C# to create the class instance and use its properties
    //to access the data members and display the data.
    class Book
    {
        int id, price;
        string title, author;

        public int bookid
        {
            get { return id; }
            set { id = value; }
        }

        public int bookprice
        {
            get { return price; }
            set { price = value; }
        }

        public string booktitle
        {
            get { return title; }
            set { title = value; }
        }

        public string bookauthor
        {
            get { return author; }
            set { author = value; }
        }



    }

    class BookDemo
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.bookid = 123;
            b.bookprice = 200;
            b.booktitle = "Pride and Prejudice";
            b.bookauthor = "Jane Austen";
            Console.WriteLine($"The book id is {b.bookid}");
            Console.WriteLine($"The book price is {b.bookprice}");
            Console.WriteLine($"The book title is {b.booktitle}");
            Console.WriteLine($"The book author is {b.bookauthor}");

        }
    }

}

