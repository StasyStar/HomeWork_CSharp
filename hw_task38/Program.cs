// ДЗ Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(rand.Next(min, max) + rand.NextDouble(), 2);
    return arr;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($" {arr[i]} ");
    }
}
double DiffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    double diff = Math.Round(max - min, 2);
    return diff;
}
double[] arr = FillArray(5, 5, 9);
double diffMaxMin = DiffMaxMin(arr);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Разница максимального и минимального значения массия = {diffMaxMin}");
