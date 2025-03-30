// CS8127.cs (7,0)

internal struct NewStruct
{
    public int a;
    public int b;

    public static implicit operator (int a, int a)(NewStruct value)
    {
        return (value.a, value.b);
    }

    public static implicit operator (int a, int b)(NewStruct value)
    {
        return (value.a, value.b);
    }
}