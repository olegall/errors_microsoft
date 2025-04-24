
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1612
    {
        public struct MyStruct
        {
            public int Width;
            
            public string Name;
        }

        //public class MyStruct
        //{
        //    public int Width;
        //}

        public class ListView
        {
            public MyStruct Size { get; set; }
        }

        public class MyClass
        {
            public MyClass()
            {
                ListView lvi;
                lvi = new ListView();
                lvi.Size.Width = 5; // CS1612  

                // You can use the following lines instead.  
                // MyStruct ms;  
                // ms.Width = 5;  
                // lvi.Size = ms;
            }

            public static void Main()
            {
                List<MyStruct> list = new List<MyStruct>();
                list[0].Name = "MyStruct42"; //CS1612  

                List<MyStruct> list2 = new List<MyStruct>();
                MyStruct ms = list[0];
                ms.Name = "MyStruct42";
                list2[0] = ms;

                MyClass mc = new MyClass();
                // Keep the console open in debug mode.  
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
