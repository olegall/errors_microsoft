// CS8149.cs (9,33)

delegate int E();

class C
{
    static int i;
    static void M()
    {
        var e = new E(() => ref i);
    }
}

class C
{
    static int i;
    static void M()
    {
        var e = new E(() => i);
    }
}