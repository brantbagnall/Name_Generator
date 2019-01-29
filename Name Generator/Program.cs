using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Name_Generator
{
    class Program
    {
        static void Main()
        {
            List<string> array1 = new List<string>();
            int numName = 0;
            numberOfOutputs();
            Console.WriteLine("Name Prefix?");
            string namePrefix = Console.ReadLine().Replace(" ", "_");

            outputName(numName, namePrefix);

            void numberOfOutputs()
            {
                try
                {
                    Console.WriteLine("Number of Names?");
                    numName = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please use numbers only.");
                    numberOfOutputs();
                }
            }

            void outputName(int number, string prefix)
            {
                for (int i = 1; i < number + 1; i++)
                {
                    array1.Add(namePrefix + "_" + i.ToString());
                };

                File.Delete("./Results.txt");

                using (StreamWriter stream = File.AppendText("./Results.txt"))
                {
                    foreach (string e in array1)
                    {
                        stream.WriteLine(e);
                    }
                    stream.Close();
                }
                Process.Start(@".\\Results.txt");
            }
        }
    }
}