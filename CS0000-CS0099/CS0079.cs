
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0079
    {
        public delegate void MyEventHandler();

        public class Class1
        {
            private MyEventHandler _e;

            public event MyEventHandler Pow
            {
                add
                {
                    _e += value;
                    Console.WriteLine("in add accessor");
                }
                remove
                {
                    _e -= value;
                    Console.WriteLine("in remove accessor");
                }
            }

            public void Handler()
            {
            }

            public void Fire()
            {
                if (_e != null)
                {
                    Pow();   // CS0079  
                    // try the following line instead  
                    _e();
                }
            }

            public static void Main()
            {
                Class1 p = new Class1();

                p.Pow += new MyEventHandler(p.Handler);
                p._e();

                p.Pow += new MyEventHandler(p.Handler);
                p._e();

                p._e -= new MyEventHandler(p.Handler);

                if (p._e != null)
                {
                    p._e();
                }

                p.Pow -= new MyEventHandler(p.Handler);

                if (p._e != null)
                {
                    p._e();
                }
            }
        }
    }
}
