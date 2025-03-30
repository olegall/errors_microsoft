using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0541
    {
        interface IFace
        {
            void F();
        }

        interface IFace2 : IFace
        {
            //void IFace.F();   // CS0541  
            void IFace.F() { }
        }
    }
}
