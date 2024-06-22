using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
            string input1 = Console.ReadLine();

            if (!double.TryParse(input1, out double number1))
            {
                Console.WriteLine("Некоректний формат числа. Будь ласка, введіть число у правильному форматі.");
                return;
            }

            Console.WriteLine("Введіть друге число:");
            string input2 = Console.ReadLine();

            if (!double.TryParse(input2, out double number2))
            {
                Console.WriteLine("Некоректний формат числа. Будь ласка, введіть число у правильному форматі.");
                return;
            }

            double sum = number1 + number2;

            Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");

            Console.ReadLine(); 
        }
    }
}