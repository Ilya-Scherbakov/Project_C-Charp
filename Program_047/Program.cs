// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void changeLineArr(int[,] arr) // Задача 53 ПАШЕТ НЕ ПРАВИЛЬНО!!!!!!!!!!!! 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int currant = arr[0, j];
            arr[0, j] = arr[arr.GetLength(0) - 1, j];
            arr[arr.GetLength(0) - 1, j] = currant;
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void changeRowArr(int[,] arr) // Задача 55
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[j, i]} ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Такого не может быть");
    }
}
void vocabularyArr(int[,] arr, int a, int b) // Задача 57
{
    int max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max) max = arr[i, j];
        }
    }    
    for (int z = 0; z <= max; z++)
    {
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == z)
                {
                    count++;
                }
            }  
        }
        Console.Write($"Число {z} встречается {count} раз ");
        Console.WriteLine();
    }
}
void deleteRowArr(int[,] arr) // Задача 59 НЕ ДОДЕЛАЛ
{
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min) min = arr[i, j];
        }
    }
        
}

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
// Console.WriteLine("Замена первойи последней строки");
// changeLineArr(array); // задача 53.
// Console.WriteLine("Замена строкна столбцы");
// changeRowArr(array); // задача 55.

vocabularyArr(array, m, n);