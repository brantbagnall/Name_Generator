using System;
using System.Collections.Generic;
using System.IO;

namespace Name_Generator
{
    class Program
    {
        static void Main()
        {
            List<string> array1 = new List<string>();
            Console.WriteLine("Number of Names?");
            int numName = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name Prefix?");
            string namePrefix = Console.ReadLine();

            outputName(numName, namePrefix);

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
                }
            }
        }
    }
}