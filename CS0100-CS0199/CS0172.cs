
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0172
    {
        // CS0172.cs  
        public class Square
        {
            public class Circle
            {
                public static implicit operator Circle(Square aa)
                {
                    return null;
                }

                public static implicit operator Square(Circle aa)
                // using explicit resolves this error  
                // public static explicit operator Square(Circle aa)  
                {
                    return null;
                }
            }

            public static void Main()
            {
                Circle aa = new Circle();
                Square ii = new Square();
                object o = (1 == 1) ? aa : ii;   // CS0172  
                                                 // the following cast would resolve this error  
                                                 // (1 == 1) ? aa : (Circle)ii;  
            }
        }
    }
}
