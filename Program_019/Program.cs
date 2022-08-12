// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int max = n % 10;

while (n > 10)
{
    if (max > (n / 10) % 10)
    {
        n = n / 10;
        max = n % 10;
    }
    else
    {
        Console.WriteLine("Число не упорядоченое");
    }
}
Console.Write("Число упорядоченное");