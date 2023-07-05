Console.WriteLine("Enter 3 numbers: ");

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (b>max)
{
    max = b;
}
else if (c>max)
{
    max = c;
}
else
{
    max =a;
}

Console.Write(max);


