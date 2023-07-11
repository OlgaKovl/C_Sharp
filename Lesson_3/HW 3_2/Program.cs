double VectorLenght (int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) +  Math.Pow(z1-z2,2));
}
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);

double result = VectorLenght(x1, y1, x2, y2, z1, z2);
Console.WriteLine(result);
