// CS8140.cs (11,7)

namespace _8140
{
    interface I<T>
    {
        T GetValue();
    }

    interface I2 : I<(int c, int d)>
    {
    }

    class C : I<(int a, int b)>, I2
    {
        public (int c, int d) GetValue()
        {
            return (1, 2);
        }
    }



    interface I<T>
    {
        T GetValue();
    }

    interface I2 : I<(int c, int d)>
    {
    }

    class C : I<(int c, int d)>, I2
    {
        public (int c, int d) GetValue()
        {
            return (1, 2);
        }
    }
}