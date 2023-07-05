Console.WriteLine("Enter a two numbers: ");

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a>b)
{
Console.Write($"max={a} min={b}");
}
else
{
Console.Write($"max={b} min={a}");   
}



