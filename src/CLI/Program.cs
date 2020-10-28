using BLL;
using System;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            ConsoleKeyInfo input;
            do
            {
                string inputData = StreamReader.GetInputData();
                Console.WriteLine();

                Console.WriteLine(Maker.IsValidProcessingData(inputData,out bool statusAboutSuccessProcessing));
                Console.WriteLine(Maker.GetResponseAboutSuccessProcessing(statusAboutSuccessProcessing));

                Console.WriteLine("Press Esc to exit.");
                input = Console.ReadKey();
                Console.WriteLine();
            } while (input.Key != ConsoleKey.Escape);

        }
    }
}
