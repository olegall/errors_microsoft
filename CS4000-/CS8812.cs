// CS8812.cs (6,22)

unsafe class C
{
    static void Method()
    {
        void* ptr1 = &Method;
    }
}

unsafe class C
{
    static void Method()
    {
        void* ptr1 = (delegate*<void>)&Method;
    }
}