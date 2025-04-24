
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1017
    {
        public class b : Exception
        {
        }

        public class a
        {
            public static void Main()
            {
                try
                {
                }

                catch   // CS1017, must be last catch  
                {
                }

                catch (b)
                {
                    throw;
                }
            }
        }
    }
}
