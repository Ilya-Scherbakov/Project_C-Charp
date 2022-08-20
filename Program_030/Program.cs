// Цикл принимает два числа А и В и возводит число А в степень В
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// int i = 1;
// while (b >= i)
// {
//     result = result * a;
//     i++;
// }
// Console.WriteLine($"Число {a} в степени {b} равно: {result}");

void Trololo(int x, int y)
{
    int result = 1;
    for (int i = 1; y >= i; i++)
    {
        result = result * x;
    }
    Console.WriteLine(result);
}
Trololo(a, b);
