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
double SumMaxMin(double[] arr)
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
    double sum = Math.Round(max + min, 2);
    return sum;
}
double[] arr = FillArray(5, 5, 9);
double sumMaxMin = SumMaxMin(arr);
PrintArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Сумма минимального и максимального значения массия = {sumMaxMin}");
