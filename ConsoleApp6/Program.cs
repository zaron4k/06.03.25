using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Lada";
            car1.Model = "Infinity";
            car1.Year = 1992;
            Console.WriteLine($"{car1.ToString()}");
            Console.WriteLine();
            Car car2 = new Car("Lamba","Wentes",2000);
            Console.WriteLine($"{car2.ToString()}");
            Console.WriteLine();

            Console.Write("Марка: ");
            string make = Console.ReadLine();
            Console.Write("Модель: ");
            string model = Console.ReadLine();
            Console.Write("Год: ");
            double year = double.Parse(Console.ReadLine());
            Car car3 = new Car(make, model, year);
            Console.WriteLine($"{car3.ToString()}");
            Console.ReadLine();
        }
    }
}
