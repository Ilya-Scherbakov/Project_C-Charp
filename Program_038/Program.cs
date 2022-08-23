// Найти произведение пар чисел в массиве. Парой считаем первый и последний 
// Результат записать в новом массиве
int[] array = new int[9];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write($" {array[i]} ");
}
Console.WriteLine();
// for (int i = 0; i < array.Length / 2; i++)
//     Console.Write($" {array[i] * array[array.Length - 1 - i]}");

void resultMult(int[] massif)
{
    for (int i = 0; i < massif.Length / 2; i++)
    if (massif.Length % 2 == 0)
    {   
        Console.Write($" {massif[i] * massif[massif.Length - 1 - i]} ");
    }
    else
    {
        Console.Write($" {massif[i] * massif[massif.Length - 1 - i]} ");
        Console.Write(massif[massif.Length / 2 ]);
    }
}

resultMult(array);