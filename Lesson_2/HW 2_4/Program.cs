//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter a number: ");

int a = int.Parse(Console.ReadLine()!);
if (a == 6 || a == 7)
    Console.WriteLine("weekend");
else
    Console.WriteLine("weekday");




