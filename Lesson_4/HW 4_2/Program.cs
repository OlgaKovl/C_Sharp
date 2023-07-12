// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int num)
{
int count = 0;
while (num > 0)
{
    count = count + num % 10;
    num = num / 10;
}
return count;
}

int a = int.Parse(Console.ReadLine()!);
int result = SumNum(a);
Console.WriteLine(result);
