// CS8172.cs (10,17)

class C
{
    void M()
    {
        ref readonly int L() => ref (new int[1])[0];

        ref readonly int x = ref L();
        ref int y = x;
    }
}

class C
{
    void M()
    {
        ref readonly int L() => ref (new int[1])[0];

        ref readonly int x = ref L();
        ref int y = ref x;
    }
}