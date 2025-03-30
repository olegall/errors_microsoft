// cs1959.cs  
class Program
{
    static void Test<T>() where T : class
    {
        const T x = null; // CS1959  
    }
}