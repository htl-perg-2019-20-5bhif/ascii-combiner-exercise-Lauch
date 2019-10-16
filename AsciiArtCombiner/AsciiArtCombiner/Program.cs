using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;

namespace AsciiArtCombiner
{
    class Program
    {
        static Class1 c = new Class1();
        static List<string> files = new List<string>();
        static Boolean isThere = true;
        static void Main(string[] args)
        {

            if (args.Length < 1)
            {
                Console.WriteLine("File amount < 2!");
                return;
            }
            else
            {
                foreach (string s in args)
                {
                    if (!File.Exists("../../TestData/" + s))
                    {
                        isThere = false;
                        Console.WriteLine("One of the following Files does not exist!: ");
                        for(int i = 0; i < args.Length; i++)
                        {
                            Console.Write(args[i] + " ");
                        }
                    }
                }

                if(isThere == true)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        files.Add(args[i]);
                    }
                    c.compareLines(files);
                }


            }

        }
    }
}
