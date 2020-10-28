using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public static class Messager
    {
        const string acceptancePackage = "ACK";
        const string nonAcceptancePackage = "NACK";
      

        public static string GetAcceptanceMessage()
        {
            return acceptancePackage;
        }
        public static string GetNonAcceptanceMessage()
        {
            return nonAcceptancePackage;
        }

    }
}
