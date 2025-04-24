
using System.Threading.Tasks;

public class Example
{
    public static async void Main()
    {
        Console.WriteLine("About to wait two seconds");
        await WaitTwoSeconds();
        Console.WriteLine("About to exit the program");
    }

    private static async Task WaitTwoSeconds()
    {
        await Task.Delay(2000);
        Console.WriteLine("Returning from an asynchronous method");
    }
}