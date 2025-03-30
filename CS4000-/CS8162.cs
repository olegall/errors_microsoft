// CS8162.cs (12,14)
namespace _8162
{
    public class Test
    {
        public struct S1
        {
            public char x;
        }

        public readonly S1 i2;

        ref char Test1()
        {
            return ref i2.x;
        }
    }

    public class Test
    {
        public struct S1
        {
            public char x;
        }

        public readonly S1 i2;
        char Test1()
        {
            return i2.x;
        }
    }
}