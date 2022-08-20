// Задает массив из 8 эл-ов и выдает их на экран

void FillArray(int[] arr)
{
    Console.Write("[");
    int i = 0;
    for (int length = arr.Length; i < length; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write($" {arr[i]}, ");
    }
    Console.Write("]");
}

// Console.Write("Введите длину массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];

int[] array = new int[8];

FillArray(array);
