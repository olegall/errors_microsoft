// cs1935.cs
// CS1935
using System;
using System.Collections.Generic;
using System.Linq;
// using System.Linq;

class Test
{
    static int Main()
    {
        int[] nums = { 0, 1, 2, 3, 4, 5 };
        IEnumerable<int> e = from n in nums
                             where n > 3
                             select n;
        return 0;
    }
}