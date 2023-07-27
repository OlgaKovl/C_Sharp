// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

void PrintArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
     Console.WriteLine();

}

int [] FillArray(int size, int from, int to)
{
    int [] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to+1);
    return arr;
}

string CheckN(int[] arr, int a)
{
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == a)
    return "Yes";
}
return "No";
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

int[] mass = FillArray(num, start, stop);
PrintArray(mass);
Console.WriteLine(CheckN(mass, b));


