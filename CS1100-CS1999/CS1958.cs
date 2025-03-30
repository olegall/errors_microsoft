// cs1958.cs  
public class MemberInitializerTest
{
    delegate void D<T>();
    public static void GenericMethod<T>() { }
    public static void Run()
    {
        D<int> genD = new D<int>(GenericMethod<int>) { }; // CS1958  
        // Try the following line instead  
        // D<int> genD = new D<int>(GenericMethod<int>);  
    }
}