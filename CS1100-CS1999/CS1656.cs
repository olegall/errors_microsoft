﻿
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1656
    {
        class Book
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
            private List<Book> list;
            static void Main(string[] args)
            {
                Program prog = new Program();
                prog.list = new List<Book>();
                prog.list.Add(new Book("The C# Programming Language", "Hejlsberg, Wiltamuth, Golde", 29.95));
                prog.list.Add(new Book("The C++ Programming Language", "Stroustrup", 29.95));
                prog.list.Add(new Book("The C Programming Language", "Kernighan, Ritchie", 29.95));
                foreach (Book b in prog.list)
                {
                    // Cannot modify an entire element in a foreach loop even with reference types. Use a for or while loop instead
                    if (b.Title == "The C Programming Language")
                        // Cannot assign to 'b' because it is a 'foreach iteration variable'  
                        b = new Book("Programming Windows, 5th Ed.", "Petzold", 29.95); //CS1656  
                }

                //With a for loop you can modify elements  
                //for(int x = 0; x < prog.list.Count; x++)  
                //{  
                //    if(prog.list[x].Title== "The C Programming Language")  
                //        prog.list[x] = new Book("Programming Windows, 5th Ed.", "Petzold", 29.95);  
                //}  
                //foreach(Book b in prog.list)  
                //    Console.WriteLine(b.Title);  

            }
        }

        class C : IDisposable
        {
            public void Dispose() { }
        }

        class CMain
        {
            unsafe public static void Main()
            {
                using (C c = new C())
                {
                    // Cannot assign to 'c' because it is a 'using variable'  
                    c = new C(); // CS1656  
                }

                int[] ary = new int[] { 1, 2, 3, 4 };
                fixed (int* p = ary)
                {
                    // Cannot assign to 'p' because it is a 'fixed variable'  
                    p = null; // CS1656  
                }
            }
        }
    }
}