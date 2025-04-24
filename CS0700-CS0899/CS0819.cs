
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0819
    {
        // cs0819.cs
        class Program
        {
            public static void Main()
            {
                var a = 3, b = 2; // CS0819

                // First correction option.
                //int a = 3, b = 2;

                // Second correction option.
                //var a = 3;
                //var b = 2;

                // Third correction option.
                //var (a, b) = (3, 2);
            }
        }

        // cs0819.cs
        class Program
        {
            public static void Main()
            {
                using (var font1 = new Font("Arial", 10.0f),
                    font2 = new Font("Arial", 10.0f)) // CS0819
                {
                }

                // First correction option.
                //using (Font font1 = new Font("Arial", 10.0f),
                //    font2 = new Font("Arial", 10.0f))
                //{
                //}

                // Second correction option.
                //using (var font1 = new Font("Arial", 10.0f)
                //{
                //    using (var font2 = new Font("Arial", 10.0f)
                //    {
                //    }
                //}
            }
        }
    }
}
