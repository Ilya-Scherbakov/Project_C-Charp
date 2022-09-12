// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void numbersRec(int a, int b) // Задача 64. сделал наоборот
{ 
    if (b == a)
        Console.Write($"ХЗ почему выводиться первым {b} ");
    else
    {
        numbersRec(a+1, b);
        Console.Write($"{a} ");
    }
}
Console.WriteLine();

// void numbersSumRec(int a, int b) // Задача 68. (неправильно)
//     int sum = 0;
//     if (a == b)
//         Console.Write("0");
//     else
//     {
//         sum = a + numbersSumRec(a, b);
//         a++;
//         Console.Write("sum");
//     }
// }
int numbersSumRec(int a, int b) // Задача 68. (ХЗ)
{
    if (b < a) return 0;
    else return b + numbersSumRec(a, b - 1);
}

Console.WriteLine("Введите значение М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
numbersRec(m, n);
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {m} до {n} равна: {numbersSumRec(m,n)}");
