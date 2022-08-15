// Программма по заданному номеру четверти показывает возможные координаты

Console.WriteLine("Введите номер четверти от 1 до 4х");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0 || n > 4)
{
    Console.WriteLine("Ввели неверное значение");
}

else if (n == 1)
{
    Console.WriteLine("Диапазон х > 0 и у > 0");
}
else if (n == 2)
{
    Console.WriteLine("Диапазон х < 0 и у > 0");
}
else if (n == 3)
{
    Console.WriteLine("Диапазон х < 0 и у < 0");
}
else if (n == 4)
{
    Console.WriteLine("Диапазон х > 0 и у < 0");
}

