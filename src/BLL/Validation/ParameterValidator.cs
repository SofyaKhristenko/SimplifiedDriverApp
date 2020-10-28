using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Validation
{
    public static class ParameterValidator
    {
        //Check existence of sound parameters
        public static bool IsNullOrEmpty(string[] parameter) => (parameter.Length == 0) ? true : false;

        //Check validation of character colon, it must be 2 character colon in package
        public static bool IsValidIndexCharacterColon(List<int> indexCharacterColon) => (indexCharacterColon.Count == 2) ? true : false;

    }
}
