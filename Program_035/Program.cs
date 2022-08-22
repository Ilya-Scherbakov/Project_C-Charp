// 32. Замена эл-ов массива положительных на отрицательные

int[] rococo = new int[10];

for (int i = 0; i < rococo.Length; i++)
{
    rococo[i] = new Random().Next(-9, 10);
    Console.Write($" {rococo[i]}");
    if (rococo[i] < 0)
    {
        rococo[i] = rococo[i] * -1;
    }
    else
    {
        rococo[i] = rococo[i] * -1;
    }
}

Console.WriteLine($"новый массив: {rococo[i]}");

// Пробую сам так
// int Func(int arr[])
// for (int i = 0; i < rococo.Length; i++)
// {
//     rococo[i] = new Random().Next(-9, 10);
//     Console.Write($" {rococo[i]}");
//     return;
// }

// Func(rococo[10])
// rococo[i] = - rococo[i];
// Console.Write($" {rococo[i]}");

// int[] rococo = new int[10];