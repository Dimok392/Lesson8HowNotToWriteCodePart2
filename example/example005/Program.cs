// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] mass = new int[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(1, 9);
    Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

int save;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(1) - 1; k++)
        if (mass[i,k]< mass[i,k + 1])
        {
            save = mass[i,k];
            mass[i,k] = mass[i,k + 1];
            mass[i,k + 1] = save;
        }
    }
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

