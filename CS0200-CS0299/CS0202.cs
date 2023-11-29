using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0202
    {
        // CS0202.cs  

        public class C1
        {
            public int Current
            {
                get
                {
                    return 0;
                }
            }

            public bool MoveNext()
            {
                return false;
            }

            public static implicit operator C1(int c1)
            {
                return 0;
            }
        }

        public class C2
        {
            public int Current
            {
                get
                {
                    return 0;
                }
            }

            public bool MoveNext()
            {
                return false;
            }

            public C1[] GetEnumerator()
            // try the following line instead  
            // public C1 GetEnumerator ()  
            {
                return null;
            }
        }

        public class MainClass
        {
            public static void Main()
            {
                C2 c2 = new C2();

                foreach (C1 x in c2)   // CS0202  
                {
                    System.Console.WriteLine(x.Current);
                }
            }
        }
    }
}
