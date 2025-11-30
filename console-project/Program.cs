using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace consoleproject;



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите марку машины: ");
            string b = Console.ReadLine();

            Console.WriteLine("Введите год мишины: ");
            int y = int.Parse(Console.ReadLine());

            Car car1 = new Car();
            Car car2 = new Car(b, y);

            car1.Print();
            car2.Print();
        }
    }

