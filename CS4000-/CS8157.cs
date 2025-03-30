// CS8157.cs (8,21)

class C
{
    ref int M()
    {
        int x = 0;
        ref int rx = ref x;
        return ref (rx = ref (new int[1])[0]);
    }
}

class C
{
    int M()
    {
        int x = 0;
        ref int rx = ref x;
        return rx = ref (new int[1])[0];
    }
}