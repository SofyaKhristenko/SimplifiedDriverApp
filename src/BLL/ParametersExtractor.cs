using BLL.Validation;
using System;
using System.Collections.Generic;

namespace BLL
{
    public static class ParametersExtractor
    {
        const char punctuation = ',';
        const char characterColon = ':';

        // get sound of frequency amd time made
        public static string[] GetSoundParameters(string parameters)
        {
            return parameters.Split(new char[] { punctuation }, StringSplitOptions.RemoveEmptyEntries);
        }

        // get list with index of character colon
        public static List<int> GetIndexCharacterColon(string package)
        {
            List<int> indexCharacterColon = new List<int>();
            for (int i = 0; i < package.Length; i++)
            {
                if (package[i] == characterColon)
                    indexCharacterColon.Add(i);
            }
            return indexCharacterColon;
        }

        // get only data betwen character colon
        public static string GetDataPackage(string package, List<int> indexCharacterColon)
        {
            string dataPackage = package.Substring(indexCharacterColon[0] + 1, package.Length - 1 - indexCharacterColon[0]);
            dataPackage = dataPackage.Trim();
            return dataPackage.Substring(0, indexCharacterColon[1]-2);
        }
    }
}
