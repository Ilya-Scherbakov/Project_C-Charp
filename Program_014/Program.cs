// На ввод два числа и проверка является ли ОДНО число квадратом ВТОРОГО (независмо какое какому)
Console.Write("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Первый вариант. Не совсем верный, т.к. проверка только одного числа
// if (num1 == num2 * num2)
// {
//     Console.WriteLine($"Число {num1} является квадратом числа {num2}");
// }
// else
// {
//     Console.WriteLine($"Число {num1} НЕ является квадратом числа {num2}");
// }

// Второй вариант. Идеальный!!!!
if (num1 == num2 * num2)
{
    Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else if (num2 == num1 * num1)
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else
{
    Console.WriteLine("НЕТ");
}
