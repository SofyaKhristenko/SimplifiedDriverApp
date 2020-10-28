using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Validation
{
    static class CommandValidator
    {
        private const char textCommand = 'T';
        private const char soundCommand = 'S';
        public static bool IsExistCommand(char[] package, int indexStartPackage)
        {

            switch (package[indexStartPackage+1])
            {
                case textCommand:
                    return true;
                case soundCommand:
                    return true;
            }
            return false;
        }

       
    }
}
