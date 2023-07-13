int Count (int num)
{
int result = 0;
    for (int i = 1; num != 0; i++)
    {
        num/=10; //num = num / 10
        result = i;
    }
    return result;
}
int A = int.Parse(Console.ReadLine()!);
int total = Count(A);
Console.WriteLine(total);

