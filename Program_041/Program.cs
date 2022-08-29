// Задача 38: Задайте массив вещественных чисел. 
//            Найдите разницу между максимальным и минимальным элементов массива.
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.


Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
double[] Fill(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(0, 20) + new Random().NextDouble(),2);
        Console.Write($" {array[i]} ");
    }
    return array;
}
Console.WriteLine();

void sumOfEl(double[] array) // задача 36
{
    Console.WriteLine("Задача №36: ");
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Сумма эл-ов на нечетных позициях: {Math.Round(sum, 2)}");
}

void MaxMin(double[] array)  // задача 38
{
    Console.WriteLine("Задача №38: ");
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимаьным значением: {Math.Round((max - min), 2)}");
}

double[] arty = Fill(n);
Console.WriteLine();
sumOfEl(arty);
MaxMin(arty);