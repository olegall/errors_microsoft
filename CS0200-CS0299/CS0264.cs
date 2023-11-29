namespace C__Errors
{
    internal class CS0264
    {
        // CS0264.cs  

        partial class MyClass<T>  // CS0264  
        {
        }

        partial class MyClass<MyType>
        {
        }
    }
}
