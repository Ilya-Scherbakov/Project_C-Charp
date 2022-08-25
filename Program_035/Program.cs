// 32. Замена эл-ов массива положительных на отрицательные

int[] rococo = new int[10];

for (int i = 0; i < rococo.Length; i++)
{
    rococo[i] = new Random().Next(-9, 10);
    Console.Write($" {rococo[i]}");
}

// Пробую сам так
int[] Func(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = arr[i] * -1;
      Console.Write($"{arr[i]}; ");
    } 
    return arr;
}

Console.WriteLine();
Func(rococo);