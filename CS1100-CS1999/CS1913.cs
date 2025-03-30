namespace C__Errors.CS1100_CS1199
{
    // cs1913.cs  
    class A
    {
        public delegate void D();
        public event D myEvent;
    }

    public class Test
    {
        static void Main()
        {

            A a = new A() { myEvent = M }; // CS1913  
        }

        public void M() { }
    }
}