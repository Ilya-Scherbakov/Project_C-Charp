// 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// 48. Задать двумерный массив размера m на n. Каждый элемент находиться по формуле A=m+n/
// 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] fillArr(int arr, int a, int b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

// задача 48.
void createArr(int[,] arr, int a, int b)
{
    for (int i = 0; i < arr.GetLenght(0); i++)
    {
        for (int j = 0; j < arr.GetLenght(1); j++)
        {
            arr[i, j] = new arr(a + b);
            Console.Write($" {arr[i, j]} ");
        }
    }
}


Console.WriteLine("Введите значения массива m and n: "); // Задача 46:
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int array[] = fillArr(array, m, n);

