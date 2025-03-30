// CS7003.cs
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var myDictionary = new Dictionary<,>();  //CS7003

        List<> var2;                               //CS7003
    }
}

// CS7003-fixed.cs
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var myDictionary = new Dictionary<int, string>();

        List<string> var2;
    }
}