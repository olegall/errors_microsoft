
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1059
    {
        // CS1059.cs  
        class Program
        {
            public enum E : sbyte
            {
                a = 1,
                b = 2
            }

            static void Main(string[] args)
            {
                const int i = 0;
                i++;            // CS1059  
                E test = E.a++; // CS1059  
            }
        }
    }
}