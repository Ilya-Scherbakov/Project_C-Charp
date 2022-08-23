// 35. Задать одномерный массив из 123 чисел, найти колличество эл-ов массива значения которых лежат 
// в отрезке от [10, 99]

int[] array = new int[12];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 200);
    Console.Write($" {array[i]} ");
    if (array[i]>=10 && array[i]<=99)
    count++;
}
Console.WriteLine();
Console.WriteLine($" кол-во эл-ов: {count}");
