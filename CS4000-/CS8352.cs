

class Program
{
    static public Span<int> CreateSpanWithValue(int size, int value)
    {
        Span<int> localSpan = stackalloc int[size];
        localSpan[0] = value;
        return localSpan;    // CS8352
    }                        // localSpan refers to stack memory that's been reclaimed.

    static public void Main()
    {
        Span<int> localSpan = CreateSpanWithValue(5, 10);
        localSpan[2] = 14;
        foreach (var item in localSpan)
        {
            Console.WriteLine(item.ToString());  // Reading from deleted object
        }
    }
    // Example of output:
    // 284945320
    // 149
    // 149
    // 1369466325
    // 284945320
}

class Program
{
    static public void FillSpanWithValue(Span<int> span, int value)
    {
        span[0] = value;
    }

    static public void Main()
    {
        Span<int> localSpan = stackalloc int[5];
        FillSpanWithValue(localSpan, 10);
        localSpan[2] = 14;
        foreach (var item in localSpan)
        {
            Console.WriteLine(item.ToString());
        }
    }
    // Output:
    // 10
    // 0
    // 14
    // 0
    // 0
}

class Program
{
    static public Span<int> CreateSpanWithValue(int size, int value)
    {
        Span<int> localSpan = new int[size];
        localSpan[1] = value;
        return localSpan;
    }

    static public void Main()
    {
        var span = CreateSpanWithValue(5, 10);
        span[2] = 14;
        foreach (var item in span)
        {
            Console.WriteLine(item.ToString());
        }
    }
    // Output:
    //0
    //10
    //14
    //0
    //0
}