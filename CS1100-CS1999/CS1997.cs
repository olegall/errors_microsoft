using System.Threading.Tasks;
class C
{
    public static async Task F1()
    {
        return await Task.Factory.StartNew(() => 1);
    }

    public static async Task F1()
    {
        await Task.Factory.StartNew(() => 1);
    }

    public static Task F1()
    {
        return Task.Factory.StartNew(() => 1);
    }
}