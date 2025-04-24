
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1763
    {
        class Program
        {
            public void Goo<T, U>(T t = default(U)) where U : T
            //public void Goo<T, U>(T t = default(T)) where U : T
            {
            }

            static void Main(string[] args)
            {

            }
        }
    }
}