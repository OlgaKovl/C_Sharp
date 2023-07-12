int a = int.Parse(Console.ReadLine()!);
int count = 1;
int count1 = -1;
if (a == 0 )
{
Console.WriteLine("1");
}
else
{
while (count <= a)
{
Console.WriteLine(Math.Pow(count, 3));
count++;
}

while (count1 >= a)
{
Console.WriteLine(Math.Pow(count1, 3));
count1--;
}

}
