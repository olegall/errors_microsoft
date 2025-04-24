
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0724
    {
        class Program
        {
            static void Test()
            {
                try
                {
                    throw new Exception();
                }
                catch
                {
                    try
                    {
                    }
                    finally
                    {
                        throw; // CS0724
                    }
                }
            }

            static void Main()
            {
            }
        }
    }
}
