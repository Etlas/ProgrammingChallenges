using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heximage
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = "";
            string[] parts = new string[8];


            Console.WriteLine("Please enter the hex you would like to convert to an image: ");
            hex = Console.ReadLine();
            parts = hex.Split(' ');
            Console.WriteLine();
            int count = 0;
            foreach (string value in parts)
            {
                string binaryval = "";
                binaryval = Convert.ToString(Convert.ToInt32(value, 16), 2);
                if (binaryval.Length != 8)
                {
                    int bitsdifference = 8 - binaryval.Length;
                    for (int j = 0; j < bitsdifference; j++)
                    {
                        binaryval = "0" + binaryval;
                    }
                } 
                parts[count] = binaryval;
                count++;
            }
            for (int i = 0; i < parts.Length; i++)
            {
                string line = "";
                foreach (char c in parts[i])
                {
                    if (c == '0')
                    {
                        line = line + " ";
                    }
                    if (c == '1')
                    {
                        line = line + "x";
                    }
                }
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
