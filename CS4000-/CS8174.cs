// CS8174.cs (7,22)

class C
{
    void M()
    {
        int i = 0;
        for (ref int rx; i < 5; i++) { }
    }
}

class C
{
    void M()
    {
        int i = 0;
        for (ref int rx = ref i; i < 5; i++) { }
    }
}