namespace C__Errors
{
    internal class CS0035
    {
        // CS0035.cs  
        class MyClass
        {
            private int i;

            public MyClass(int i)
            {
                this.i = i;
            }

            public static implicit operator double(MyClass x)
            {
                return (double)x.i;
            }

            public static implicit operator decimal(MyClass x)
            {
                return (decimal)x.i;
            }
        }

        class MyClass2
        {
            static void Main()
            {
                MyClass x = new MyClass(7);
                object o = -x;   // CS0035  
                                 // try a cast:  
                                 // object o = - (double)x;  
            }
        }
    }
}
