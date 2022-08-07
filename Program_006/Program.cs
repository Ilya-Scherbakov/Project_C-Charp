// Введите два числа и определить какое больше
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > num1)
{
    Console.WriteLine("Максимальное число: ");
    Console.Write(num2);
}
else
{
    Console.WriteLine("Максимальное число: ");
    Console.Write(num1);
}