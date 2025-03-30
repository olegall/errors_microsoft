using System.Runtime.CompilerServices;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task M(MyTask<int> x)
    {
        var z = await x;
        System.Console.WriteLine(z);
    }
}

public class MyTask<TResult>
{
    readonly MyTaskAwaiter<TResult> awaiter;
    public MyTask(TResult value)
    {
        this.awaiter = new MyTaskAwaiter<TResult>(value);
    }
    public static MyTaskAwaiter<TResult> GetAwaiter() => throw new NotImplementedException();
}

public class MyTaskAwaiter<TResult> : INotifyCompletion
{
    TResult value;
    public MyTaskAwaiter(TResult value)
    {
        this.value = value;
    }
    public bool IsCompleted { get => true; }
    public TResult GetResult() => value;
    public void OnCompleted(Action continuation) => throw new NotImplementedException();
}