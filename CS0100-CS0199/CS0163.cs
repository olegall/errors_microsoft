﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0163
    {
        // CS0163.cs  
        public class MyClass
        {
            public static void Main()
            {
                int i = 0;

                switch (i)   // CS0163  
                {
                    // Compiler error CS0163 is reported on the following line.  
                    case 1:
                        i++;
                    // To resolve the error, uncomment one of the following example statements.  
                    // return;  
                    // break;  
                    // goto case 3;  

                    case 2:
                        i++;
                        return;

                    case 3:
                        i = 0;
                        return;

                    // Compiler error CS0163 is reported on the following line.  
                    default:
                        Console.WriteLine("Default");
                        // To resolve the error, uncomment the following line:  
                        //break;  
                }
            }
        }
}
