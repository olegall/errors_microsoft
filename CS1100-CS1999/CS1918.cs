// cs1918.cs  
public struct MyStruct
{
    public int i;

}
public class Test
{
    private MyStruct str = new MyStruct();
    public MyStruct Str
    {
        get
        {
            return str;
        }
    }
    public static int Main()
    {
        Test t = new Test { Str = { i = 1 } }; // CS1918  
        return 0;
    }
}