﻿// ДЗ Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        arr[i] = rand.Next(min, max);
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($" {arr[i]} ");
    }
}
int SumOddNum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(i % 2 > 0)
            sum += arr[i];
    }
    return sum;
}
int[] arr = FillArray(5, 1, 11);
// int[] arr = {-4, -6, 89, 6};
int sumOddNum = SumOddNum(arr);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Сумма чисел с нечетными индексами = {sumOddNum}");
