using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1731
    {
        delegate double D();
        D d = () => { return "Who knows the real sword of Gryffindor?"; };
    }
}