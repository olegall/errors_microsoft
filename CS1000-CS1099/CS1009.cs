using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1009
    {
        // CS1009-a.cs  
        class MyClass
        {
            static void Main()
            {
                // The following line causes CS1009.  
                string a = "\m";
                // Try the following line instead.  
                // string a = "\t";  
            }
        }

        // CS1009-b.cs  
        class MyClass2
        {
            static void Main()
            {
                // The following line causes CS1009.  
                string filename = "c:\myFolder\myFile.txt";
                // Try one of the following lines instead.  
                // string filename = "c:\\myFolder\\myFile.txt";  
                // string filename = @"c:\myFolder\myFile.txt";  
            }
        }
    }
}
