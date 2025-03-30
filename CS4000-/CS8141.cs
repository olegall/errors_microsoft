// CS8141.cs (10,27)
using System.Collections;

public interface IGrabber<out T>
{
    T GetOne();
}

class SomeGrabber : IGrabber<(int, int)>
{
    public (int a, int b) GetOne()
    {
        return (1, 2);
    }

    public (int, int) GetOne()
    {
        return (1, 2);
    }
}