using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{

    public abstract class Book
    {
        public abstract void display();
        

    }
     class MyBook:Book
    {
        private readonly string _title;
        private readonly string _author;
        private readonly int _price;

        public MyBook(string title, string author, int price)
        {
           _title = title;
           _author = author;
           _price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Auhtor: {_author}");
            Console.WriteLine($"Price: {_price}");
        }
    }


 
}
