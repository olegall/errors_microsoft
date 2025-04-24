

public class C
{
    private int counter = 1;
    public void IncreaseCounter()
    {
        static void localFunc(int addition)
        {
            this.counter += addition;   // CS8422 due to reference to 'this'
            base.ToString();            // CS8422 due to reference to 'base'

            // Also for implicit 'this' or 'base' references:
            counter += addition;   // CS8422 due to implicit reference to 'this'
            ToString();            // CS8422 due to implicit reference to 'base'
        }
        localFunc(10);
        Console.WriteLine(this.counter);
    }
}