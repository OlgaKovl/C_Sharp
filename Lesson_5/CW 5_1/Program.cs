﻿void Print(int[] arr)
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


void ChangeNum(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
arr[i] *= -1;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = FillArray(num, start, stop);
Print(mass);
ChangeNum(mass);
Print(mass);