// CS8145.cs (4,13)

public class C
{
    public ref int Property1 { get; }
}

public class C
//public class C_
{
    private int property1;

    public ref int Property1 => ref property1;
}

public class C
{
    public int Property1 { get; }
}