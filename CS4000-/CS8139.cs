// CS8139.cs (9,38)
namespace _8139
{
    public class Base
    {
        public virtual (object a, object b) M((object c, object d) x) { return x; }
    }

    class C : Base
    {
        public override (object, object) M((object c, object d) y) { return y; }
    }

    class C : Base
    {
        public override (object a, object b) M((object c, object d) y) { return y; }
    }
}