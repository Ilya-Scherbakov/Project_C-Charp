// На вход принимает число "А" и выдает сумму числел от 1 до А. ЧЕРЕЗ МАССИВЫ И ФУНКЦИИ

// void ArfProg(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     Console.WriteLine($"сумма чисел равна: {sum}");
// }

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// ArfProg(a);
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// ArfProg(b);
// Console.Write("Введите число C: ");
// int c = Convert.ToInt32(Console.ReadLine());
// ArfProg(c);

// На вход принимает число N и выдает произведение от 1 до N

void GeoProg(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    Console.WriteLine($"геометрическая прогрессия будет равна: {sum}");
}
Console.Write("Введите число N:");
int n = Convert.ToInt16(Console.ReadLine());
GeoProg(n);
