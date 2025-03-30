// CS8129.cs (11,52)

class C
{
    static void Main()
    {
        long x;
        string y;
        (x, y) = new C();
    }

    public int Deconstruct(out int a, out string b)
    {
        a = 1;
        b = "hello";
        return 42;
    }

    public void Deconstruct(out int a, out string b)
    {
        a = 1;
        b = "hello";
    }
}