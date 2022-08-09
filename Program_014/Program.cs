// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Являеься квадратом числа");
}
else
{
    Console.WriteLine("НЕ является квадратом числа");
}