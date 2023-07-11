
int RNum = new Random().Next();

Console.WriteLine(RNum);
if (RNum < 100)
{
    Console.WriteLine("no third num");
}

while (RNum > 999)
{
    RNum = RNum / 10;
}
Console.WriteLine(RNum % 10);


