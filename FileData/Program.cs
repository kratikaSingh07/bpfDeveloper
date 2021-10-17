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
            FileDetails fileDetails = new FileDetails();

            if (Helper.IsFileVersionExists(args[0]))
            {
                var fileVersion = fileDetails.Version(args[1]);
                Console.WriteLine("fileVersion " + fileVersion);
            }
            else if(Helper.IsFileSizeExists(args[0]))
            {
                var fileSize = fileDetails.Size(args[1]);
                Console.WriteLine("fileSize " + fileSize);
            }
            else
            {
                Console.WriteLine("Invalid arguments");
            }

            Console.ReadLine();
        }
    }
}
