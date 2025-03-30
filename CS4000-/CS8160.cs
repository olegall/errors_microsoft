// CS8160.cs (8,20)

class Program
{
    readonly int i = 0;

    ref int M()
    {
        return ref i;
    }
}

class Program
{
    readonly int i = 0;

    int M()
    {
        return i;
    }
}