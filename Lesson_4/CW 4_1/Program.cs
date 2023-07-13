int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i; // all_sum = all_sum + i

    return all_sum;

}

int a = int.Parse(Console.ReadLine()!);
int result = SumNum(a);
Console.WriteLine(result);