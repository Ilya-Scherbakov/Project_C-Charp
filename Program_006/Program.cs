// Введите два числа и определить какое больше, а какое меньше
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > num1)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(num2);
    Console.Write("Минимальное число: ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(num1);
    Console.Write("Минимальное число: ");
    Console.WriteLine(num2);
}