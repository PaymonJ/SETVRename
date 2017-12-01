using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETVRename
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryString = args[0];

            if(!Directory.Exists(directoryString))
            {
                Console.WriteLine("Invalid directory - exiting.");
                System.Environment.Exit(0);
            }

            string lastFolderName = Path.GetFileName(directoryString);
            string[] seasonArr = lastFolderName.Split(null);
            int season = Convert.ToInt32(seasonArr[seasonArr.Length - 1]);

            string name;
            if (season < 10) name = "S0" + season + "E";
            else name = "S" + season + "E";

            int counter = 1;

            DirectoryInfo directory = new DirectoryInfo(directoryString);
            FileInfo[] fileData = directory.GetFiles();
            foreach (FileInfo file in fileData)
            {
                if (counter < 10)
                {
                    Console.WriteLine("Renaming " + file.Name + " to " + name + "0" + counter + file.Extension);
                    File.Move(file.FullName, file.DirectoryName + @"\" + name + "0" + counter + file.Extension);
                }
                else
                {
                    Console.WriteLine("Renaming " + file.Name + " to " + name + counter + file.Extension);
                    File.Move(file.FullName, file.DirectoryName + @"\" + name + counter + file.Extension);
                }

                counter++;
            }
        }
    }
}
