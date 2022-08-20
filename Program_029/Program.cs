// Выводит массив из 8 элемнтов, заполненный 0 и 1 в случайном порядке.

void FillArray(int[] arr)
{
    int i = 0;
    for (int length = arr.Length; i < length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write($" {arr[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);