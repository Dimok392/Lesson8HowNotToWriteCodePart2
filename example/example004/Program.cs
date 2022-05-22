// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
int min = mass[0, 0];
int mini = 0;
int minj = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < min)
        {
            min = mass[i, j];
            mini = i;
            minj = j;
        }
    }
}
Console.WriteLine();

int [,]newmass=new int [m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if(i!=mini & j!=minj)
        {
            int a=i;
            int b=j;
            if (i>mini) a--;
            if (j>minj) b--;

            newmass[a,b]=mass[i,j];
        }
    }
}
for (int i = 0; i < m-1; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        Console.Write(newmass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();