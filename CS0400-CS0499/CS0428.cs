﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0428
    {
        public class ExampleClass
        {
            public int Method1() { return 1; }
            public static ExampleClass Method2() { return null; }
        }

        class Program
        {
            delegate int Del1();
            delegate object Del2();

            static void Main(string[] args)
            {
                ExampleClass ec = new ExampleClass();

                // The following assignment statement causes compiler error CS0428.  
                // It attempts to assign the address of Method1 to an integer variable.
                // You can only assign the address to an appropriate delegate type.
                int i = ec.Method1;

                // Del1 is a delegate type that is appropriate for a method like
                // Method1 that returns an int. The following assignment statement  
                // does not cause an error.  
                Del1 d1 = ec.Method1;

                // You can invoke Method1 and assign the int that is returned to
                // integer variable i.  
                i = ec.Method1();
                //i = ec.Method1;

                // The following assignment statement causes compiler error CS0428.  
                // It attempts to assign the address of Method2 to an instance of
                // ExampleClass. You can only assign the address to a delegate type.
                ec = ExampleClass.Method2;

                // Del2 is a delegate type that is appropriate for a method like
                // Method2 that returns an instance of a class. The following assignment  
                // statement does not cause an error.  
                Del2 d2 = ExampleClass.Method2;

                // Similarly, you can invoke Method2 and assign the result returned to ec.  
                ec = ExampleClass.Method2();
            }
        }


    }
}
