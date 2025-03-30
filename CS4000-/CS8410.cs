using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // error CS8410: 'Example': type used in an asynchronous using statement
        // must be implicitly convertible to 'System.IAsyncDisposable' or implement
        // a suitable 'DisposeAsync' method.
        await using var example = new Example();
    }
}

class Example
{
}