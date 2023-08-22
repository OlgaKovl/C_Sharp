using System;

namespace SimpleEvenNumbersRecursion
{
    class Program
    {
        static void PrintEvenNumbers(int start, int end)
        {
            if (start > end)
            {
                return;
            }

            if (start % 2 == 0)
            {
                Console.WriteLine(start);
            }

            PrintEvenNumbers(start + 1, end);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение (M): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение (N): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Чётные числа от {m} до {n}:");
            PrintEvenNumbers(m, n);

            Console.ReadLine();
        }
    }
}




