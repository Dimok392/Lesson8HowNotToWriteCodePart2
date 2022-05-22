// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
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
int [] save = new int [mass.Length];
int [] elcount = new int [mass.Length];
int count = 0;
bool exist;
for (int i = 0; i < mass.GetLength(0); i++)
{
    exist = false;
    for (int j = 0; j < mass.GetLength(1);j++)
    {
        for (int k = 0; k < count; k++)
        {
           if (mass[i,j]==save[k])
           {
               exist=true;
               elcount[k]++;
               break;
           } 
        }
        if (exist==false)
        {
            save[count]=mass[i,j];
            elcount[count]=1;
            count++;
        }
    }
}
for (int i = 0; i < count; i++)
{
    System.Console.WriteLine(save [i] + "-"+elcount[i]);
}