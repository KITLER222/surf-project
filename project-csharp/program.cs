using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();

            string result = Reverse(s);
            Console.WriteLine(result);
        }

        static string Reverse(string s)
        {
            if (s.Length <= 1)
                return s;

            return Reverse(s.Substring(1)) + s[0];
        }
    }
