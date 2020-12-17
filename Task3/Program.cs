using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string str = Console.ReadLine();
            string res = string.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            Console.WriteLine(res);

        }
    }
}