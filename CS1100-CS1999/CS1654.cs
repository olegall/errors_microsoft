using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1654
    {
        struct Book
        {
            public string Title;
            public string Author;
            public double Price;

            public Book(string t, string a, double p)
            {
                Title = t;
                Author = a;
                Price = p;
            }
        }

        class Program
        {
            List<Book> list;
            static void Main(string[] args)
            {
                //Use a collection initializer to initialize the list  
                Program prog = new Program();
                prog.list = new List<Book>();
                prog.list.Add(new Book("The C# Programming Language", "Hejlsberg, Wiltamuth, Golde", 29.95));
                prog.list.Add(new Book("The C++ Programming Language", "Stroustrup", 29.95));
                prog.list.Add(new Book("The C Programming Language", "Kernighan, Ritchie", 29.95));
                foreach (Book b in prog.list)
                {
                    //Compile error if Book is a struct  
                    //Make Book a class to modify its members  
                    b.Price += 9.95; // CS1654  
                }
                var book = prog.list[0];
                book.Price = 0;
            }
        }
    }
}
