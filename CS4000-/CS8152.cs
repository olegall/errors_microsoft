// CS8152.cs (6,21)

public interface ITest
{
    ref readonly int M();
}
public class Test : ITest
{
    public int M() => 0;
}

//public class Test : ITest
//{
//    int m;
//    public ref readonly int M() => ref m;
//}