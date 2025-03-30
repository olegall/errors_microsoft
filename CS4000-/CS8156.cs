// CS8156.cs (7,27)

class Test
{
    delegate ref int D1();

    void Test1()
    {
        D1 d1 = () => ref 2 + 2;
    }
}

//class Test
//{
//    delegate int D1();

//    void Test1()
//    {
//        D1 d1 = () => 2 + 2;
//    }
//}