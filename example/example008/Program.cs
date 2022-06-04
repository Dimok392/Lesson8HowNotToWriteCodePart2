// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int o = int.Parse(Console.ReadLine());
void Print(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
        }
        Console.WriteLine();
    }
}
void DrayD(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 31);
            }
        }
    }
}
int[,,] matrix1 = new int[m, n, o];
DrayD(matrix1);
Print(matrix1);
Console.WriteLine();
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(2); k++)
        {
            Console.Write($"{matrix1[i,j,k]} i={i}, j={j}, k={k}");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}