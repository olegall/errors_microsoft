using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0112
    {
        abstract public class MyClass
        {
            public abstract void Foo();
        }

        public class MyClass2 : MyClass
        {
            override public static void Foo()   // CS0112, remove static keyword
            {
            }
            public static int Main()
            {
                return 0;
            }
        }

        static class A {} 
        //static class B : A {}
        static class C : object {}

        class A2 
        {
            public static void Foo() { }
            public static void Foo2() { }
            public static void Foo3() { }
        }
        
        class B2 : A2 
        {
            public static void Foo() { }
            public static new void Foo2() { }
            public static override void Foo3() { }
        }
    }
}
