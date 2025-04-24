namespace C__Errors
{
    // CS0030.cs  
    namespace x
    {
        public class iii
        {

            //public static implicit operator iii(int aa)
            //{
            //    return null;
            //}

            //public static implicit operator int(iii aa)
            //{
            //    return 0;
            //}


            public static iii operator ++(iii aa)
            {
                return (iii)0;   // CS0030  
                                 // uncomment the conversion routines to resolve CS0030  
            }

            public static void Main()
            {
            }
        }
    }

    internal class CS0030
    {

    }
}
