using System;



namespace Lassons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 произвольных числа.");
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), c = 2;
            Console.WriteLine("Среднее арефмитическое двух введённых чисел: " + ((a + b) / c), ".");
        }
    }
}
