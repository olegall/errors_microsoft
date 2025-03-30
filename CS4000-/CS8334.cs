// CS8334.cs (5,14)

class Program
{
    static ref int M(in int arg1, in (int Alice, int Bob) arg2)
    {
        return ref arg2.Alice;
    }
}

class Program
{
    static ref readonly int M(in int arg1, in (int Alice, int Bob) arg2)
    {
        return ref arg2.Alice;
    }
}