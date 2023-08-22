using System;

namespace SumOfNaturalNumbersRecursion
{
    class Program
    {
        static int CalculateSum(int start, int end)
        {
            if (start > end)
            {
                return 0;
            }

            return start + CalculateSum(start + 1, end);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение (M): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение (N): ");
            int n = int.Parse(Console.ReadLine());

            int sum = CalculateSum(m, n);

            Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");

            Console.ReadLine();
        }
    }
}