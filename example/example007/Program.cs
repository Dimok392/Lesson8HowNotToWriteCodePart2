// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
m = n;
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
void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);

        }

    }
}
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
FillMatrix(matrix1);
Print(matrix1);
Console.WriteLine();
FillMatrix(matrix2);
Print(matrix2);
int[,] proizmatrix = new int[m, n];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        proizmatrix[i, j] = 0;
        for (int l = 0; l < m; l++)
        {
            proizmatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            
        }
    }

}
Console.WriteLine();
Print(proizmatrix);