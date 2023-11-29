using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1015
    {
        // CS1015.cs  
        class Sample
        {
            static void Main()
            {
                try
                {
                }
                catch (int)   // CS1015, int is not derived from System.Exception  
                {
                }
            }
        }
    }
}
