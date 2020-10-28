using System;

namespace BLL.Validation
{
    public static class CharactersValidator
    {
        const int startRange = 32;
        const int endRange = 127;


        public static bool IsValidPackageCharacters(string package) => (!IsEmptyPackage(package) && IsCharactersValid(package));
        private static bool IsEmptyPackage(string package) => string.IsNullOrEmpty(package);

        private static bool IsCharactersValid(string package)
        {
            foreach (var symbolPackage in package)
            {
                int indexASCII = Convert.ToInt32(symbolPackage);
                if (!IsAcceptableIndex(indexASCII))
                    return false;
            }
            return true;
        }

        private static bool IsAcceptableIndex(int indexASCII) => (indexASCII >= startRange && indexASCII <= endRange) ? true : false;
       
    }
}
