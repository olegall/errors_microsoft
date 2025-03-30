// CS8333.cs (3,36)
class Program
{
    static ref T F4<T>(in T t) => ref t;
}

class Program
{
    static ref readonly T F4<T>(in T t) => ref t;
}