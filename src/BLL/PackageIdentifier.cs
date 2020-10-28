namespace BLL
{
    public static class PackageIdentifier
    {
        const char startSymbolPackage = 'P';

        // Get only package payload
        public static string GetDataPackage(string inputData, int indexStartPackage) =>
            GetSubPackage(inputData, indexStartPackage);
        
        //Cut unimportant symbols befor start symbol
        private static string GetSubPackage(string inputData, int indexStartPackage)
        {
            int endPosition = inputData.Length - indexStartPackage - 1;
            return inputData.Substring(indexStartPackage + 1, endPosition);
        }

        // Get exist start symbol of package 
        public static int GetStartIndexPackage(string inputData) => inputData.IndexOf(startSymbolPackage);
    }
}
