using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0181
    {
        [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
        unsafe class Attr : Attribute
        {
            public Attr(delegate*<void> d) { }
        }
        unsafe class C
        {
            [UnmanagedCallersOnly]
            [Attr(&M1)]
            static void M1()
            {
            }
        }
    }
}
