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

int GetEvenCountArray(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] %2 ==0){
            count++;
        }
    }
    return count;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = FillArray(num, start, stop);
Print(mass);
int countResult = GetEvenCountArray(mass);
Console.WriteLine(countResult);