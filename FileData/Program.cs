using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args[0].Contains("-v"))
            {
                FileDetails fileDetails = new FileDetails();
                var returnVersion = fileDetails.Version(args[1]);
                Console.WriteLine("fileDetails version " + returnVersion);
            }
            
            Console.ReadLine();
        }
    }
}
