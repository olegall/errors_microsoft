namespace C__Errors
{
    internal class CS0250
    {
        // CS0250.cs  
        class B
        {
        }

        class C : B
        {
            ~C()
            {
                base.Finalize();   // CS0250  
            }

            public static void Main()
            {
            }
        }
    }
}
