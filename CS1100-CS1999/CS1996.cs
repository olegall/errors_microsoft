using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class C
{
    private readonly Dictionary<string, string> keyValuePairs = new();

    public async Task<string> ReplaceValueAsync(string key, HttpClient httpClient)
    {
        lock (keyValuePairs)
        {
            var newValue = await httpClient.GetStringAsync(string.Empty);
            if (keyValuePairs.ContainsKey(key)) keyValuePairs[key] = newValue;
            else keyValuePairs.Add(key, newValue);
            return newValue;
        }
    }
}