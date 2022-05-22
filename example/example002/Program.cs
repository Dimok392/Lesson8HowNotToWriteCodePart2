// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
if (m!=n)
{
    System.Console.WriteLine("Решить задачу невозможно");
    return;
}
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 9);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// Мой вариант
for (int j = 0; j < mass.GetLength(0); j++)
{
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Вариант с семинара

// for (int i = 0; i < mass.GetLength(0); i++)
// {
// for (int j = i; j < mass.GetLength(1); j++)
// {
// int save = mass[i, j];
// mass[i, j] = mass[j, i];
// mass[j, i] = save;
// }
//  Console.WriteLine();
// }
// Console.WriteLine();
// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1); j++)
//     {
//         Console.Write(mass[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
