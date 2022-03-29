using System;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            Console.WriteLine(a.IsOdd());
            Console.WriteLine("--------------------------------------");
            int b = 8;
            Console.WriteLine(b.IsEven());
            Console.WriteLine("--------------------------------------");
            string c = "Salam12";
            Console.WriteLine(c.IsContainsDigit());
            Console.WriteLine("--------------------------------------");
            string d = "AZERBAYCAN TEXNIKI UNIVERSITETI";
            Console.WriteLine(d.ToCapitalize());
            Console.WriteLine("--------------------------------------");
            string e = "Azerbaycan";
            Console.WriteLine(e.GetValueIndexes('D'));
            Console.WriteLine(e.GetValueIndexes('A'));
        }
    }
}
