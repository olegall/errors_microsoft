// CS8171.cs (8,13)

class Test
{
    void A()
    {
        int a = 123;
        ref int x = ref a;
        var y = ref x;
    }
}

class Test
{
    void A()
    {
        int a = 123;
        ref int x = ref a;
        var y = x;
    }
}