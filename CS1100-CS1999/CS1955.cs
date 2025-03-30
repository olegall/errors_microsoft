// cs1955.cs  
class A
{
    public int x = 0;
    public int X
    {
        get { return x; }
        set { x = value; }
    }
}

class Test
{
    static int Main()
    {
        A a = new A();
        a.x(); // CS1955  
        a.X(); // CS1955  
        // Try this line instead:  
        // int num = a.x;  
    }
}