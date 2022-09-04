// ТОЖЕ САМОЕ ЧТО И 44 ПРОГРАММА, ТОЛЬКО РЕШНИЕ С СЕМИНАРА

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = i + j;
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        if (i % 2 == 0 && j % 2 == 0) num[i, j] = num[i, j] * num[i, j];
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}

// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int[m, n];
int sum = 0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        if (i == j) sum = sum + num[i, j];
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма элементов находящихся на главной диагонали = {sum}");