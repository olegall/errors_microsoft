using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0473
    {
        public interface ITest<T>
        {
            int TestMethod(int i);
            int TestMethod(T i);
        }

        public class ImplementingClass : ITest<int>
        {
            int ITest<int>.TestMethod(int i) // CS0473
            {
                return i + 1;
            }

            public int TestMethod(int i)
            {
                return i - 1;
            }
        }

        class T
        {
            static int Main()
            {
                ImplementingClass a = new ImplementingClass();
                if (a.TestMethod(0) != -1)
                    return -1;

                ITest<int> i_a = a;
                System.Console.WriteLine(i_a.TestMethod(0).ToString());
                if (i_a.TestMethod(0) != 1)
                    return -1;

                return 0;
            }
        }
    }
}
