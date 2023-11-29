using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0031.cs
    namespace CS0031
    {
        public class Program
        {
            public static void Main()
            {
                int num = (int)2147483648M; //CS0031
                                            // Try using a larger numeric type instead.
                                            // long num = (long)2147483648M; //CS0031

                const decimal d = -10M; // Decimal literal
                unchecked
                {
                    const byte b = (byte)d; // CS0031
                                            // For small values try using a signed byte instead.
                                            // const sbyte b = (sbyte)d;
                }
            }
        }
    }

    //internal class CS0031
    //{
    //}
}
