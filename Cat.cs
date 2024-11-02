using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Cat
    {
        private string name;
        private double weight = -1;
        public Cat(string CatName)// Конструктор класса Cat
        {
            Name = CatName;
        }        
        public string Name //Свойство переменной name с проверкой на ввод "являются ли все символы буквами?"
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public double Weight //Свойство переменной weight с проверкой на ввод "не меньше ли введённое число чем 1"
        {
            get
            {
                return this.weight;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Вес не может быть нулевым или отрицательным");
                    }
                    else
                    {
                        this.weight = value;
                    }
                }
                catch
                {
                    Console.WriteLine("Введённая переменная не является типом Double");
                }
            }
        }
        public void EnterWeight()//проверка на ввод отрицательных и нулевых чисел
        {
            while (Weight == -1 || Weight == 0)
            {
                Console.WriteLine($"Введите вес кота {Name}");
                string doub = Console.ReadLine();
                if (IsDouble(doub))
                {
                    Weight = double.Parse(doub);
                }
            }
        }
        public bool IsDouble(string doub) // функция проверки, является ли возможным конвертировать данную строку в тип double
        {
            double x = 1.1;
            if (double.TryParse(doub, out x))
            {
                return true;
            }
            Console.WriteLine("Вес не может означаться буквами");
            return false;
        }
        public void Meow()//Функция пишущая строку в console
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!({this.weight})");
        }
    }
}
