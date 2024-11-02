using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Назови кота");
            Cat cat1 = new Cat(Console.ReadLine());

            Console.WriteLine("Назови кота");
            Cat cat2 = new Cat(Console.ReadLine());

            Console.WriteLine($"Переименуй кота {cat1.Name}");
            cat1.Name = Console.ReadLine();

            Console.WriteLine($"Переименуй кота {cat2.Name}");
            cat2.Name = Console.ReadLine();

            cat1.EnterWeight();
            cat2.EnterWeight();

            cat1.Meow();
            cat2.Meow();

            Console.ReadKey();
        }
    }
}
