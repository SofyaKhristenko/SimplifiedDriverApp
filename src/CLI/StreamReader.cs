using System;

namespace CLI
{
    static class StreamReader
    {
        public static string GetInputData()
        {
            bool repeatReadData;
            string inputData = string.Empty;
            do
            {
                var streamSymbol = Console.ReadKey();
                repeatReadData= IsEndInputData(streamSymbol.KeyChar,ref inputData);
            } while (!repeatReadData);
            return inputData;
        }

        private static bool IsEndInputData(char symbol, ref string inputData)
        {
            bool endInput = StreamValidator.IsEndPackage(symbol);
            if (!endInput)
                inputData = string.Concat(inputData, symbol);
            return endInput;
        }



    }
}
