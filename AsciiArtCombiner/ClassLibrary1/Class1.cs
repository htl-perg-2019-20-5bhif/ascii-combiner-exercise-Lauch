using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
        int linesNum;
        List<int> characters = new List<int>();
        int run = 0;
        Boolean compatible = true;
        int help = 0;
        public void compareLines(List<string> s)
        {
            while (compatible)
            {
                foreach (string a in s)
                {
                    run++;
                    if (run > 1)
                    {
                        string[] lines = File.ReadAllLines("../../TestData/" + a);
                        if (linesNum != lines.Length)
                        {
                            Console.WriteLine("Incompatible Line Amount");
                            compatible = false;
                        }
                        foreach (string line in lines)
                        {
                            if (line.Length != characters[help])
                            {
                                Console.WriteLine("Incompatible Character Length");
                                compatible = false;
                            }
                        }
                    }
                    else
                    {
                        string[] lines = File.ReadAllLines("../../TestData/" + a);
                        linesNum = lines.Length;
                        foreach (string line in lines)
                        {
                            characters.Add(line.Length);
                        }
                    }

                }
            }
            if (compatible == true)
            {
                connectFiles(s);
            }
        }

        public void connectFiles(List<string> s)
        {
            int run = 0;
            string[] lines = null;
            string[] lines2;
            char[] cArray = null;
            char[] cArray2;
            string text;
            foreach (string a in s)
            {
                if (run > 0)
                {
                    lines2 = File.ReadAllLines("../../TestData/" + a);
                    for (int i = 0; i < lines2.Length; i++)
                    {
                        cArray = lines[0].ToCharArray();
                        cArray2 = lines2[0].ToCharArray();
                        for (int j = 0; j < cArray.Length; j++)
                        {
                            if (cArray[j] == ' ')
                            {
                                cArray[j] = cArray2[j];
                            }
                        }
                    }
                }
                else
                {
                    lines = File.ReadAllLines("../../TestData/" + a);

                }
                run++;
            }
            text = new string(cArray);
            Console.Write(text);
        }
    }
}
