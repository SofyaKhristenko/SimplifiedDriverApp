using BLL.Validation;
using System;

namespace BLL.Commands
{
   public static class SoundProducer
    {
        //Get beep
        public static void GetSound(string[] soundParameters)
        {
            Console.Beep(Convert.ToInt32(soundParameters[0]), Convert.ToInt32(soundParameters[1]));
        }

    }
}
