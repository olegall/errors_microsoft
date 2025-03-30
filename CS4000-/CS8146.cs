// CS8146.cs (5,18)

public class C
{
    private ref int number;

    private ref int Number { init => number = value; }
}

public class C
{
    private ref int number;

    private ref int Number => ref number;
}