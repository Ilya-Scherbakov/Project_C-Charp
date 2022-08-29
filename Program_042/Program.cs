// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] interArr(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
    }
    return array;
}
void countNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
            Console.WriteLine(count);
        }
    }
}
Console.Write("Введите какое кол-во чисел вы будите вводить: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = interArr(x);
Console.WriteLine();
countNum(x);