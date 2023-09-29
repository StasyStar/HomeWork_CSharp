// ДЗ Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// using System;
// public class Answer {
//   public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
//       // Введите свое решение ниже
//     double[,] matrix = new double[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int l = 0; l < n; l++)
//         {
//             matrix[i, l] = Math.Round(rand.Next(minLimitRandom, maxLimitRandom) + rand.NextDouble(), 2);
//         }
//     }
//     return matrix;
//   }
//   public static void PrintArray(double[, ] matrix) {
//       // Введите свое решение ниже
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//             Console.Write($"{matrix[i, l]} ");
//         Console.WriteLine();
//     }
//   }
//   // Не удаляйте и не меняйте метод Main! 
//   public static void Main(string[] args) {
//     int m, n, minLimitRandom, maxLimitRandom;
//     if (args.Length >= 4) {
//       m = int.Parse(args[0]);
//       n = int.Parse(args[1]);
//       minLimitRandom = int.Parse(args[2]);
//       maxLimitRandom = int.Parse(args[3]);
//       double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//         // Выберем случайные индексы трех элементов матрицы array
//         int row1 = new Random().Next(0, m);
//         int col1 = new Random().Next(0, n);
//         int row2 = new Random().Next(0, m);
//         int col2 = new Random().Next(0, n);
//         int row3 = new Random().Next(0, m);
//         int col3 = new Random().Next(0, n);
//         // Проверяем, являются ли выбранные элементы дробными числами
//         bool isFractional1 = (array[row1, col1] % 1) != 0;
//         bool isFractional2 = (array[row2, col2] % 1) != 0;
//         bool isFractional3 = (array[row3, col3] % 1) != 0;
//         // Если два из трех элементов не являются дробными числами, то бросаем исключение
//         if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
//         {
//             Console.WriteLine("Все ок!");
//         }
//         else
//         {
//             throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
//         }
//     } else {
//       m = 3;
//       n = 4;
//       minLimitRandom = -10;
//       maxLimitRandom = 10;
//       double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//       PrintArray(result);
//     }
//   }
// }





// // ДЗ Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//       // Введите свое решение ниже
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int l = 0; l < matrix.GetLength(1); l++)
//                 Console.Write($"{matrix[i,l]}\t");
//             Console.WriteLine();
//         }
//     }
  
//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//       // Введите свое решение ниже
//         int[,] matrix = new int[n, m];
//         matrix[0,0] = 1;
//         int count = matrix[0,0];
//         for (int i = 0; i < n; i++)
//         {
//              for (int l = 0; l < m; l++)
//              {
//                 if(matrix[i,l] != 0)
//                     continue;

//                 count += k;
//                 matrix[i,l] = count;
//              }
//         }
//         return matrix;
//     }
  
//     public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
//     {  
//       // Введите свое решение ниже
//         int[] array = new int[2];
//         if(rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
//             return array;
            
//         for (int i = 0; i < rowPosition; i++)
//         {
//             for (int l = 0; l < columnPosition; l++)
//                 if(matrix[i, l] == matrix[rowPosition-1, columnPosition-1])
//                     array[0] = matrix[i, l];
//                     array[1] = 0;
//         }   
//         return array;
//     }
//     public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//       // Введите свое решение ниже
//         if(results[0] != 0)
//             Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         else
//             Console.WriteLine($"There is no such index");
       
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//            x = 8;
//            y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }





// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//       // Введите свое решение ниже
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int l = 0; l < matrix.GetLength(1); l++)
//                 Console.Write($"{matrix[i, l]}\t");
//             Console.WriteLine();
//         }
//     }
  
//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//       // Введите свое решение ниже
//         int[,] matrix = new int[n, m];
//         matrix[0,0] = 1;
//         int count = matrix[0,0];
//         for (int i = 0; i < n; i++)
//         {
//             for (int l = 0; l < m; l++)
//             {
//                 if(matrix[i,l] != 0)
//                     continue;
//                 count += k;
//                 matrix[i,l] = count;
//             }
//         }
//         return matrix;
//     }
  
//     static void PrintListAvr (double [] list)
//     {
//     Console.WriteLine($"The averages in columns are: ");
//       // Введите свое решение ниже
//         for (int i = 0; i < list.Length; i++)
//         {
//            Console.Write(String.Format("{0:0.00}\t", list[i]));
//         }

//     }

//     static double[] FindAverageInColumns (int[,] matrix)
//     { 
//       // Введите свое решение ниже
//         double[] array = new double[matrix.GetLength(1)];
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int l = 0; l < matrix.GetLength(1); l++)
//             {
//                 array[l] += matrix[i, l];
//             }
//         }
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             array[i] = array[i] / matrix.GetLength(0);
//         }
//         return array;
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k;

//         if (args.Length >= 3) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 4;
//            m = 5;
//            k = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintListAvr(FindAverageInColumns(result));
//     }
// }




