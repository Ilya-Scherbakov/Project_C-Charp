// Выводит третью цифру заданного числа или сообщает что ее нет

int num = new Random().Next(10, 10000);
Console.WriteLine(num);

if (num => 100)
{
    while (num => 1000)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра: {num % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}