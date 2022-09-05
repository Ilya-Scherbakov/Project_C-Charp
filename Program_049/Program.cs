// РЕШЕНИЕ РЕКУРСИЯМИ!
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Доп. задача с рекурсией: Найти факториал N.

// void numbers(int N) // Задача 63. Но это вроде не рекурсия
// {
//     for (int i = 1; i <= N; i++)
//         Console.Write($"{i} ");
// }
// numbers(6);
void numbersRec(int n) // Задача 63. Решена рекурсией.
{
    if (n == 1)
    Console.Write($"ХЗ почему выводиться первым {n} ");
    else
    {
        numbersRec(n-1);
        Console.Write($"{n} ");
    }
}
numbersRec(12);



// void numbersMN(int M, int N) // Задача 65. Но это вроде не рекурсия
// {
//     for (int i = M; i <= N; i++)
//         Console.Write($"{i} ");
// }
// numbersMN(6, 10);
// string numbersRec(int a, int b) // Задача 65. РЕШЕНА РЕКУРСИЕЙ.
// {
//     if (a <= b)
//         return $"{a} " + numbersRec(a + 1, b);
//     else
//         return string.Empty;
// }
// Console.WriteLine("Введите значение М: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numbersRec(m, n));

// double Factorial(int N) // Доп. задача Факториал. Решенная рекурсией
// {
//     if (N == 1) return 1;
//     else return N* Factorial(N-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }