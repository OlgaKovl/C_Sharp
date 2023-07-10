int TakeNum(int num)
{
    Console.WriteLine(num);
    int fnum = num / 100;
    int tnum = num % 10;
    return (fnum * 10 + tnum);  
}

int ft_num = new Random().Next(100, 1000);
int result = TakeNum(ft_num);
Console.WriteLine(result);
