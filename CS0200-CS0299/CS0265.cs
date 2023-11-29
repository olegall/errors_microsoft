namespace C__Errors
{
    internal class CS0265
    {
        // CS0265.cs  
        public class GenericsErrors
        {
            interface IFace1 { }
            interface IFace2 { }
            partial class PartialBadBounds<T> where T : IFace1 { } // CS0265  
            partial class PartialBadBounds<T> where T : IFace2 { }
        }
    }
}
