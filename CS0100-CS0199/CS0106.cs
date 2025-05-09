﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0106
    {
        interface I
        {
            void M1();
            void M2();
            public abstract void M3();
        }

        public class MyClass : I
        {
            public readonly int Prop1 { get; set; }   // CS0106
            public int Prop2 { get; readonly set; }   // CS0106

            public void I.M1() { }   // CS0106
            abstract void I.M2() { }   // CS0106

            public void AccessModifierOnLocalFunction()
            {
                public void LocalFunction() { }   // CS0106
            }

            public readonly void ReadonlyMethod() { }   // CS0106
                                                        // Move the `readonly` keyword after the `ref` keyword
            public readonly ref int ReadonlyBeforeRef(ref int reference)   // CS0106
            {
                return ref reference;
            }

            public static void Main() { }
        }

        public readonly class ReadonlyClass { }   // CS0106

        public abstract class MyClass2 : I
        {
            void I.M1() { }
            void I.M2() { }
            public abstract void M3();
        }

        public abstract class MyClass3 : MyClass2 
        {
            //public abstract void M3();
            public override void M3() { }
            //public new void M3() { }
        }
        
        public abstract class MyClass4 : MyClass3 
        {
            public override void M3() { }
        }
        
        public abstract class MyClass5 : MyClass4
        {
            public new void M3() { }
        }
        
        public abstract class MyClass6 : MyClass5
        {
            public new void M3() { }
        }
        
        public abstract class MyClass7 : MyClass6
        {
            //public override void M3() { }
        }
    }
}
