class C
{
    private int i;
    public required ref readonly int Number => ref i;

    public required int Number
    {
        get
        {
            return i;
        }
        set
        {
            i = value;
        }
    }
}