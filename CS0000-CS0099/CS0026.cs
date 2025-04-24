namespace C__Errors
{
    internal class CS0026
    {
        public class A
        {
            public static int i = 0;
            
            public static void Main()
            {
                // CS0026  
                this.i = this.i + 1;
                // Try the following line instead:  
                // i = i + 1;
            }

            public int i2 = 0;
            void Main2()
            {
                // CS0026
                this.i2 = this.i2 + 1;
            }
        }
    }
}
