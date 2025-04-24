using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    async Task Example(IAsyncEnumerator<int> enumerator)
    {
        // error CS8411: Asynchronous foreach statement cannot operate on variables
        // of type 'IAsyncEnumerator<T>' because 'IAsyncEnumerator<T>' does not
        // contain a suitable public instance definition for 'GetAsyncEnumerator'
        await foreach (int i in enumerator) // TODO
        {
        }
    }
}