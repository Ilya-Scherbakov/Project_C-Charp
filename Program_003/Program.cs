// На ввод запрашивает 2 числа и проверяет является ли первое число квадратом второго

Console.WriteLine("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1 / num2;

if (num3 == num2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}
