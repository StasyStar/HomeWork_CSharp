// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// 1-е решение
System.Console.Write("Enter one number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    System.Console.Write(" " + i);
    i += 2;
}


// 2-е решение
// System.Console.Write("Enter one number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= N; i+=2)
// {
//     Console.Write(" " + i);
// }