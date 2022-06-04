// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
m=n;
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);

        }

    }
}
int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
int b = 0;
int summstring = 0;
int[] masssumm = new int[m];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        summstring = summstring + mass[i, j];
        b = summstring;
        masssumm[i] = b;
    }
    summstring = 0;
}
Console.WriteLine();
for (int i = 0; i < masssumm.GetLength(0); i++)
{
    Console.Write(masssumm[i] + " ");
}
Console.WriteLine();
int min = masssumm[0];
int numstring = 0;
for (int k = 0; k < masssumm.Length - 1; k++)
{
    if (masssumm[k + 1] < min)
    {
        min = masssumm[k + 1];
        numstring=k+1;
        // Console.WriteLine(k+1);
    }
    // Console.WriteLine(k+1);
}
Console.WriteLine();
System.Console.WriteLine($"Наименьшая сумма элементов строки массива  {min}");
Console.WriteLine();
System.Console.WriteLine($"Индекс строки с нименшей суммой {numstring}");