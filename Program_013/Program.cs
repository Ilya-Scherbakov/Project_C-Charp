// See https://aka.ms/new-console-template for more information

int num = new Random().Next(10, 100);
Console.WriteLine(num);
int a = 7;
int b = 23;

if (num % a == 0 && num % b == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}