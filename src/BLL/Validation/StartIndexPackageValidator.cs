using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Validation
{
    static class StartIndexPackageValidator
    {
        public static bool IsValidStartIndexPackage(int indexStartPackage) => (indexStartPackage >= 0) ? true : false;

        // Check is exist start symbol of package 
        public static bool IsExistStartSymbol(char[] package)
        {
            for (int i = 0; i < package.Length; i++)
            {
                if (Convert.ToInt32(package[i]).Equals(80))
                    return true;
            }
            return false;
        }
        private static int GetIndexStartSymbol(string package)
        {
          return package.IndexOf('P');
        }
        public static bool IsValidStartIndex(string package)
        {
            int indexStartPackage = GetIndexStartSymbol(package);
           return IsValidStartIndexPackage(indexStartPackage);
        }
    }
}
