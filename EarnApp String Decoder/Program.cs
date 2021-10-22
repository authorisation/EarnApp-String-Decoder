using System;
using System.IO;

namespace EarnApp_String_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "made in china (by auth Ltd.)";
            Console.WriteLine("made by auth mit liebe");
            Console.WriteLine("string :");
            int bufSize = 10000;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));

            string line = Console.ReadLine();
            if(line == null) { return; }
                try {
                string decoded = line.decode();
                Console.WriteLine("\n");
                Console.WriteLine(decoded);
                }
                catch (Exception e) {
                Console.WriteLine("invalid string");
                }
            Console.ReadKey();
        }
    }
}
