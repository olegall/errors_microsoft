using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0313
    {
        // cs0313.cs  
        public interface BaseInterface { }
        public struct ImplStruct : BaseInterface { }

        public class TestClass
        {
            public T? TestMethod<T, U>(T t) where T : struct, U
            {
                return t;
            }
        }

        public class NullableTest
        {
            public static void Run()
            {

                TestClass tc = new TestClass();
                tc.TestMethod<ImplStruct?, BaseInterface>(new ImplStruct?()); // CS0313  
            }
            public static void Main()
            { }
        }
    }
}
