// На ввод принимает число и проверяет кратность одновременно 7 и 23

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int a = 7;
int b = 23;

if (num % a == 0 && num % b == 0)
{
    Console.WriteLine($"Число: {num} кратно одновременно 23 и 7");
}
else
{
    Console.WriteLine($"Число: {num} НЕ кратно одновременно 23 и 7");
}