void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
     Console.WriteLine();

}

double [] FillArray(int size)
{
    double [] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().NextDouble();
    return arr;
}

double GetDeltaMaxMinArray(double[] arr){
    double min = arr.Min();
    double max = arr.Max();
    return max-min;
}

int num = int.Parse(Console.ReadLine()!);
double[] mass = FillArray(num);
Print(mass);
double countResult = GetDeltaMaxMinArray(mass);
Console.WriteLine(countResult);