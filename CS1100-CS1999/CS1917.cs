// cs1917.cs  
class CS1917
{
    public struct TestStruct
    {
        public int i;
    }
    public class C
    {
        public readonly TestStruct str = new TestStruct();
        public static int Main()
        {
            C c = new C { str = { i = 1 } }; // CS1917  
            return 0;
        }
    }
}