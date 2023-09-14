// ДЗ Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            count++;
    }
    return count;
}
int[] arr = FillArray(5, 100, 1000);
int evenNum = EvenNum(arr);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Количество четных чисел в массиве = {evenNum}");
