using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21
{
    class Program
    {
        static bool Pako(string n)        //function which check the words by polyndrome principle
        {
            bool t = true;
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])//This code check by the method which get last symbol of the words and 
                { return false; }
            }
            return t;

        }
        static void Main(string[] args)
        {
            string words = System.IO.File.ReadAllText(@"C:\Users\HP\Desktop\C# test\lab2.1\1.txt");//reads the text in file in given by directory

            if (Pako(words))
            {
                Console.WriteLine("Yes");
            }
            else
            { Console.WriteLine("No"); }
            Console.ReadKey();
        }
    }
}