// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
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
int save;
for (int i = 0; i < mass.GetLength(1); i++)
{
    save = mass[0,i];
    mass[0,i] = mass[mass.GetLength(0) - 1, i];
    mass[mass.GetLength(0) - 1, i]=save;
    // System.Console.Write(mass[0, i] + " ");
    // System.Console.Write(mass[mass.GetLength(0) - 1, i] + " ");
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
