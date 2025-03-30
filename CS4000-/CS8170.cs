// CS8170.cs (8,14)

struct Program
{
    public int d;

    public ref int M()
    {
        return ref d;
    }
}

public class Other
{
    public void Method()
    {
        var p = new Program();
        var d = p.M();
    }
}



delegate void D();

struct Program
{
    public event D d;

    public D M()
    {
        return d;
    }
}



public struct Program
{
    public int d;
}

public static class Extensions
{
    public static ref readonly int RefD(this in Program program)
    {
        return ref program.d;
    }
}

public class Other
{
    public void Method()
    {
        var p = new Program();
        var d = p.RefD();
    }
}