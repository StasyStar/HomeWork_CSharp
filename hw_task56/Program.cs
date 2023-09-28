﻿// ДЗ Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int SetNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(min, max);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int[] GetArray(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[i] += matrix[i, j];
        }
    }
    return arr;
}

void MinIndex(int[,] matrix, int[] arr)
{
    int min = 0;
    for (int j = 1; j < matrix.GetLength(0); j++)
    {
        if (arr[j] < arr[min])
            min = j;
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {min}");         
}

int rows = SetNumber("Введите количество строк массива: ");
int columns = SetNumber("Введите количество столбцов массива: ");
int[,] matrix = GetMatrix(rows, columns, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] arr = GetArray(matrix);
Console.WriteLine(string.Join(", ", arr));
MinIndex(matrix, arr);
