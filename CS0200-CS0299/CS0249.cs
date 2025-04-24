

namespace C__Errors
{
    internal class CS0249
    {
        // CS0249.cs  
        class MyClass
        {
            protected override void Finalize()   // CS0249  
            // try the following line instead  
            // ~MyClass()  
            {
            }

            public static void Main()
            {
            }
        }
    }
}
