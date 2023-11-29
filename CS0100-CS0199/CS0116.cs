using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0116.cs
    namespace x
    {
        // A namespace can be placed within another namespace.
        using System;

        // These variables trigger the CS0116 error as they are declared outside of a struct or class.
        public int latitude;
        public int longitude;
        Coordinate coord;

        // Auto-properties also fall under the definition of this rule.
        public string LocationName { get; set; }

        // This method as well: if it isn't in a class or a struct, it's violating CS0116.
        public void DisplayLatitude()
        {
            Console.WriteLine($"Lat: {latitude}");
        }

        public struct Coordinate
        {
        }

        public class CoordinatePrinter
        {
            public void DisplayLongitude()
            {
                Console.WriteLine($"Longitude: {longitude}");
            }

            public void DisplayLocation()
            {
                Console.WriteLine($"Location: {LocationName}");
            }
        }
    }
}
