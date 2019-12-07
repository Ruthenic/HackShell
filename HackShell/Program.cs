using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;




namespace HackShell
{
    class Program
    {
        static void Main()
        {
            //init all var
            string currentdir = "C:\\users\\dalle\\Documents";
            string currentcommand;
            string[] PATH = { "C:\\Hackshell\\bin", };

            for (int i = 0; i < 5;)
            {


                //ask for command
                Console.Write(currentdir);
                Console.Write(">");
                currentcommand = (Console.ReadLine());
                string[] openfileexts = new string[] { ".bat", ".exe" };

                if (currentcommand == "dir")
                {
                    Console.WriteLine(currentdir);
                }
                if (currentcommand == "list")
                {
                    string[] filesindir = Directory.GetFiles(currentdir);
                    string[] foldsindir = Directory.GetDirectories(currentdir);
                    Console.WriteLine(currentdir, "contains:");
                    foreach (string name in foldsindir)
                    {
                        Console.WriteLine(name);
                    }
                    foreach (string name in filesindir)
                    {
                        Console.WriteLine(name);
                    }
                    Console.WriteLine();
                }
                if (currentcommand.Contains("cd"))
                {
                    string newpath = currentcommand.Replace("cd ", "");
                    if (!newpath.Contains(":\\"))
                    {
                        newpath = currentdir + "\\" + newpath;
                    }
                    currentdir = newpath;
                }
                if (openfileexts.Any(currentcommand.Contains))
                {
                    System.Diagnostics.Process.Start(currentdir + "\\" + currentcommand);
                }

            }

        }
    }
}
