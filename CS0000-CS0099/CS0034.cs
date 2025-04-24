namespace C__Errors
{

    // CS0034.cs
    public class A
    {
        // Allows for the conversion of A object to int.
        public static implicit operator int(A s)
        {
            return 0;
        }

        public static implicit operator string(A i)
        {
            return null;
        }
    }

    public class B
    {
        public static implicit operator int(B s)
        // One way to resolve this CS0034 is to make one conversion explicit.
        // public static explicit operator int (B s)
        {
            return 0;
        }

        public static implicit operator string(B i)
        {
            return null;
        }

        public static implicit operator B(string i)
        {
            return null;
        }

        public static implicit operator B(int i)
        {
            return null;
        }
    }

    public class C
    {
        public static void Main()
        {
            A a = new A();
            B b = new B();
            b = b + a;   // CS0034
                            // Another way to resolve this CS0034 is to make a cast.
                            // b = b + (int)a;
        }
    }
    

    namespace CS0034
    {
        class TestClass2
        {
            public void Test()
            {
                TestClass o1 = new TestClass();
                TestClass o2 = new TestClass();
                TestClass o3 = o1 & o2; //CS0034
            }
        }

        class TestClass
        {
            public static implicit operator int(TestClass o)
            {
                return 1;
            }

            public static implicit operator TestClass(int v)
            {
                return new TestClass();
            }

            public static implicit operator bool(TestClass o)
            {
                return true;
            }
        }

    }
}
