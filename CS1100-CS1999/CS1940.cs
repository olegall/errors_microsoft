// cs1940.cs  
 //must include explicitly for types defined in 3.5  
namespace _1940
{
    class Test
    {
        public delegate int Dele(int x);
        int num = 0;
        public int Select(Func<int, int> d)
        {
            return d(this.num);
        }
        public int Select(Dele d) // CS1940  
        {
            return d(this.num) + 1;
        }
        public static void Main()
        {
            var q = from x in new Test()
                    select x;
        }
    }
}