namespace C__Errors
{
    internal class CS0263
    {
        // CS0263.cs  
        // compile with: /target:library  
        class B1
        {
        }

        class B2
        {
        }
        partial class C : B1  // CS0263 – is the base class B1 or B2?  
        {
        }

        partial class C : B2
        {
        }
    }
}
