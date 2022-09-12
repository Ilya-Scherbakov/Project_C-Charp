// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void fillArr(int[,] array) // Метод создает массив из случайных чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void printArr(int[,] arr)  // Печатает массив в терминале
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
void sortArr(int[,] arr) // Задача: 54
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] > arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите колличество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine("полученный массив");
fillArr(array);
printArr(array);

Console.WriteLine();
sortArr(array);
printArr(array);

int minsum = Int32.MaxValue; // Задача: 56
int indexLine = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];       
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine = i;
    }
}
Console.WriteLine("Наименьшая сумма элементов в строке номер: " + (indexLine + 1) + ", сумма: " + (minsum));

Console.Write("Введите количество строк матрицы А ");  // Задача: 58
int sizeA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А ");
int sizeA2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B ");
int sizeB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B ");
int sizeB2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[sizeA1, sizeA2];
int[,] matrixB = new int[sizeB1, sizeB2];
int size1 = sizeA1;
int size2 = sizeB2;

if (sizeA2 == sizeB1)
{
    fillArr(matrixA);
    fillArr(matrixB);
    int[,] matrixC = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size2; k++)
            {
               matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Матрица - А");
    printArr(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица - В");
    printArr(matrixB);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц А и В матрица С");
    printArr(matrixC);
}
else Console.WriteLine("Умножение матриц невозможно!");



