// CS8177.cs (20,26)

using System.Threading.Tasks;
namespace _8177
{
    class E
    {
        public class Enumerator
        {
            public ref int Current => throw new System.NotImplementedException();
            public bool MoveNext() => throw new System.NotImplementedException();
        }

        public Enumerator GetEnumerator() => new Enumerator();
    }

    class C
    {
        public async static Task Test()
        {
            await Task.CompletedTask;

            foreach (ref int x in new E())
            {
                System.Console.Write(x);
            }
        }
    }

    class C
    {
        public async static Task Test()
        {
            await Task.CompletedTask;

            foreach (int x in new E())
            {
                System.Console.Write(x);
            }
        }
    }
}