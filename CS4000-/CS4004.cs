using System.Threading.Tasks;

public static class C
{
    public static unsafe async Task<string> ReverseTextAsync(string text)
    {
        return await Task.Run(() =>
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            fixed (char* pText = text)
            {
                char* pStart = pText;
                char* pEnd = pText + text.Length - 1;
                for (int i = text.Length / 2; i >= 0; i--)
                {
                    char temp = *pStart;
                    *pStart++ = *pEnd;
                    *pEnd-- = temp;
                }

                return text;
            }
        });
    }
}