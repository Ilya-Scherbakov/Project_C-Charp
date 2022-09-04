// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.         

double[,] fillArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 2);
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void posSearchArr(double[,] arr, int x, int y)
{
    // Console.WriteLine("Введите для поиска позицию элемента массива: ");
    // int cordinat = Convert.ToInt32(Console.ReadLine());
    // x = cordinat / 10;
    // y = cordinat % 10;

    if (x < arr.GetLength(0) && y < arr.GetLength(1)) Console.WriteLine(arr[x, y]);
    else Console.WriteLine("Такого элемента не существует");
}
void arithSum(double[,] arr, int x, int y)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"среденеарифмитеческое столбца {j + 1}: {Math.Round(sum / arr.GetLength(0), 0)}");
    }
}

Console.WriteLine("Введите значения массива m and n: "); // Задача 47:
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
fillArr(array);
Console.WriteLine("Задача 50");
Console.WriteLine("Введите для поиска позицию элемента массива: "); // Задача 50:
int cordinat = Convert.ToInt32(Console.ReadLine());
int[] searchArray = { cordinat / 10, cordinat % 10 }; // как это сделать в функции???
posSearchArr(array, searchArray[0], searchArray[1]);
Console.WriteLine("Задача 52");
arithSum(array, m, n); // Задача 52