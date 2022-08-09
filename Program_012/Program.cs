// На ввод два числа. Проверять является ли второе кратно первому. Если нет, то вывести остаток

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num1}, является кратным числу {num2}");
}
else
{
    Console.WriteLine($"Число {num1}, НЕявляется кратным числу {num2}. Остаток от деления равен: {num1 % num2}");
}