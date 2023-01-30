//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
GetMaxNumberInRow(array);
PrintArray(array);
//Methods---------------------------------------------------- 
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void GetMaxNumberInRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int e = 1; e < array.GetLength(1); e++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
}*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
//суммой элементов: 1 строка
/*int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] SumRow = SumEveryRow (array);
GetNumberRowMin(SumRow);
//Methods---------------------------------------------------- 
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] SumEveryRow(int[,] array)
{
    int[] sumarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            sumarray[i] = sum;
        }
    }
    return sumarray;
}
void GetNumberRowMin(int[] array)
{
    int min = array[0];
    int minrow = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i]; minrow = i + 1;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {minrow}");
}*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
/*Console.Write("Введите количество строк матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы 1 : ");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray1(rows1, columns1, 1, 9);
PrintArray(array1);
Console.WriteLine();
Console.Write("Введите количество строк матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray2(rows2, columns2, 1, 9);
PrintArray(array2);
Console.WriteLine();
if (rows1 != columns2)
{
    Console.WriteLine("Произведение двух матриц найти невозможно");
}
else
{
    int[,] ChangedArray = GetMultiplicationArrays(array1, array2);
    PrintArray(ChangedArray);
}
//Methods---------------------------------------------------- 
int[,] GetArray1(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
int[,] GetArray2(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] GetMultiplicationArrays(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
     for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int m = 0; m < array2.GetLength(1); m++)
            {
                int mult = array1[i, m] * array2[m, j];
                sum += mult;
            }
            newArray[i, j] = sum;
        }
    }
    return newArray;
}*/


