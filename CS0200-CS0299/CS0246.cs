using System;
using System.Collections.Generic;
using System.Diagnostics;

// The following declaration generates CS0246.  
using myAliasName = List<int>;

// To avoid the error, fully qualify List.  
using myAliasName2 = System.Collections.Generic.List<int>;

namespace C__Errors
{
    internal class CS0246
    {
        public class MyClass
        {
            // The following line causes CS0246. To fix the error, uncomment  
            // the using directive for the namespace for this attribute,  
            // System.Diagnostics.  
            [Conditional("A")]
            public void Test()
            {
            }

            public static void Main()
            {
            }
        }

        class ExampleClass
        {
            public bool supports(object o, Type t)
            {
                // The following line causes CS0246. You must use an  
                // actual type, such as ExampleClass, String, or Type.  
                if (o is t)
                {
                    return true;
                }
                return false;
            }
        }

        class Program
        {
            public static void Main()
            {
                ExampleClass myC = new ExampleClass();
                myC.supports(myC, myC.GetType());
            }
        }
    }
}
