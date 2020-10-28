using BLL.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public static class Maker
    {
        //Check validation of package. If correct, processing them and display a response. 
        //Else only get non-acceptance response
        public static string IsValidProcessingData(string inputData, out bool statusAboutSuccessProcessing)
        {
            statusAboutSuccessProcessing = false;
            if (!StartIndexPackageValidator.IsExistStartSymbol(inputData.ToCharArray()))
                return Messager.GetNonAcceptanceMessage();

            int indexStartPackage = PackageIdentifier.GetStartIndexPackage(inputData);
            if (!PackagePayloadVerifier.IsValidPackage(inputData, indexStartPackage))
                return Messager.GetNonAcceptanceMessage();

            string package = PackageIdentifier.GetDataPackage(inputData, indexStartPackage);
            char command = PackagePayloadVerifier.GetCommand(package);
            List<int> indexCharacterColon = ParametersExtractor.GetIndexCharacterColon(package);

            if (!ParameterValidator.IsValidIndexCharacterColon(indexCharacterColon))
                return Messager.GetNonAcceptanceMessage();
            statusAboutSuccessProcessing = GetCommandResult(command, package, indexCharacterColon, out string result);
            return result;
        }

        public static string GetResponseAboutSuccessProcessing(bool status)
            => status.Equals(true) ? Messager.GetAcceptanceMessage() : Messager.GetNonAcceptanceMessage();

        // processing command
        private static bool GetCommandResult(char command, string package, List<int> indexCharacterColon, out string result)
        {
            string parameters = ParametersExtractor.GetDataPackage(package, indexCharacterColon);

            return PackagePayloadVerifier.DoCommand(command, parameters, out result);
        }
    }
}

