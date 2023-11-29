
namespace C__Errors
{
    internal class CS0261
    {
        // CS0261.cs  
        partial class A  // CS0261 – A declared as a class here, but as a struct below  
        {
        }

        partial struct A
        {
        }
    }
}
