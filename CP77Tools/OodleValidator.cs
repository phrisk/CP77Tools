using System;
using System.Configuration;
using System.IO;

namespace CP77Tools
{
    public static class OodleValidator
    {
        private const string OodleFilename = "oo2ext_7_win64.dll";
        
        public static void Validate()
        {
            if (!File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}{OodleFilename}"))
                throw new ConfigurationException($"CP77Tools require the {OodleFilename}\nCopy 'Cyberpunk 2077\\bin\\x64\\{OodleFilename}' into '{AppDomain.CurrentDomain.BaseDirectory}'");
        }
    }
}