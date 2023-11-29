using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0600
    {
        public class idx
        {
            public virtual int this[int iPropIndex]
            {
                get
                {
                    return 0;
                }
                set
                {
                }
            }
        }

        public class MonthDays : idx
        {
            [IndexerName("MonthInfoIndexer")]   // CS0609, delete to resolve this CS0609
            public override int this[int iPropIndex]
            {
                get
                {
                    return 0;
                }
                set
                {
                }
            }
        }

        public class test
        {
            public static void Main(string[] args)
            {
            }
        }
    }
}
