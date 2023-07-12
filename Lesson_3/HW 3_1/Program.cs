int a = int.Parse(Console.ReadLine()!);

if (a / 10000 == a % 10)
{
    a = a % 10000;
    a = a / 10;
    
    if (a / 100 == a % 10)
    Console.WriteLine("yes");
}


else
    Console.WriteLine("no");

