using System;

namespace CLI
{
    static class StreamValidator
    {
        const int endSymbolPackage = 69;
        public static bool IsEndPackage(char symbol)
        {
            int intexASCII = Convert.ToInt32(symbol);
            return intexASCII.Equals(endSymbolPackage);
        }
    }
}
