using BLL.Commands;
using BLL.Validation;
using System;

namespace BLL
{
    public static class PackagePayloadVerifier
    {
        const char textCommand = 'T';
        const char soundCommand = 'S';

        //check package validation 
        public static bool IsValidPackage(string inputData, int indexStartPackage) =>
            (CommandValidator.IsExistCommand(inputData.ToCharArray(), indexStartPackage) &&
            StartIndexPackageValidator.IsValidStartIndexPackage(indexStartPackage) &&
                CharactersValidator.IsValidPackageCharacters(inputData));

        //Get command data
        public static char GetCommand(string package) => package[0];

        // processing command and get info about result
        public static bool DoCommand(char command, string parameters, out string info)
        {
            switch (command)
            {
                case textCommand:
                    info = Printer.GetText(parameters);
                    return true;
                case soundCommand:
                    string[] soundParameters = ParametersExtractor.GetSoundParameters(parameters);
                    if (!ParameterValidator.IsNullOrEmpty(soundParameters))
                    {
                        SoundProducer.GetSound(soundParameters);
                        info = string.Empty;
                        return true;
                    }
                    break;
            }
            info = string.Empty;
            return false;
        }
    }
}
