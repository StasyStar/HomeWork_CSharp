// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1РЕШЕНИЕ
string[] GetNumber(string message)
{
    Console.Write($"Введите произвольное количество чисел через запятую {message}: ");
    string text = Console.ReadLine();
    string[] nums = text.Split(new char[] { ',' });
    return nums;
}
int[] NumArray(string[] nums)
{
    int newNum = 0;
    int[] arr = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        newNum = int.Parse(nums[i]);
        arr[i] = newNum;
    }   
    return arr;
}
int CountNumber(int[] newNums)
{
    int count = 0;
    for (int i = 0; i < newNums.Length; i++)
    {
        if(newNums[i] > 0)
        count++;
    }
    return count;
}
string[] nums = GetNumber("M");
// Console.WriteLine(string.Join(" ", nums));
int[] newNums = NumArray(nums);
Console.WriteLine(string.Join(" ", newNums));
int count = CountNumber(newNums);
Console.WriteLine($"Пользователь ввел {count} положительных чисел");

// 2РЕШЕНИЕ (НЕ РАБОТАЕТ)

// int GetNumber(string message)
// {
//     Console.Write($"Введите произвольное количество чисел через запятую {message}: ");
//     string text = Console.ReadLine();
//     int nums = Convert.ToInt32(text);
//     return nums;
// }
// int nums = GetNumber("M");
// System.Console.WriteLine($"Пользователь ввел {nums} положительных чисел");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1РЕШЕНИЕ
// double GetNumber(string message)
// {
//     Console.Write($"Введите значение {message}: ");
//     double num = int.Parse(Console.ReadLine());
//     return num;
// }
// void Cross (double b1, double b2, double k1, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k2 * x + b2;
//     Console.Write($"({x}; ");
//     Console.Write($"{y})");
// }
// double b1 = GetNumber("b1");
// double b2 = GetNumber("b2");
// double k1 = GetNumber("k1");
// double k2 = GetNumber("k2");
// Cross(b1, b2, k1, k2);



// 2РЕШЕНИЕ
// int k = 0;
// int b = 1;
// int x = 0;
// int y = 1;
// int line1 = 1;
// int line2 = 2;
// double[] firstLine = InputLineData(line1);
// double[] secondLine = InputLineData(line2);

// double GetNumber(string message)
// {
//     Console.Write($"{message}:");
//     double result = Convert.ToDouble(Console.ReadLine());
//     return result;
// }
// double[] InputLineData(int numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[k] = GetNumber($"Введите коэффициет для {numberOfLine} прямой: ");
//     lineData[b] = GetNumber($"Введите константу для {numberOfLine} прямой: ");
//     return lineData;
// }
// double[] FindCoord(double[] firstLine, double[] secondLine)
// {
//     double[] coord = new double[2];
//     coord [x] = (firstLine[b] - secondLine[b]) / (secondLine[k] - firstLine[k]);
//     coord [y] = firstLine[b] * coord[x] + firstLine[b];
//     return coord;
// }
// bool ValidateLines(double[] firstLine, double[] secondLine)
// {
//     if (firstLine[k] == secondLine[k])
//     {
//         if (firstLine[b] == secondLine[b])
//         {
//             Console.WriteLine("Прямые совпадают!");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны!");
//             return false;
//         }
//     }
//     return true;
// }
// if (ValidateLines(firstLine, secondLine))
// {
//     double[] coord = FindCoord(firstLine, secondLine);
//     Console.Write($"Точка пересечения уравнений у = {firstLine[k]} * x + {firstLine[b]} и у = {secondLine[k]} * x + {secondLine[b]} ");
//     Console.WriteLine($" имеет координаты ({coord[x]}, {coord[y]})");
// }

