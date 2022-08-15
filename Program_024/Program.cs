// На ввод пятизначное число и проверяет является ли оно палиндромом
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = (n / 10000) % 10;
int b = (n / 1000) % 10;
int c = (n / 10) % 10;
int d = n % 10;

if (n > 9999 && n < 100000)
{
    if (a == d && b == c)
    {
        Console.WriteLine("Является палиндромом");
    }
    else
    {
        Console.WriteLine("НЕ является");
    }
}
else
{
    Console.WriteLine("Ввели неверное значение");
}