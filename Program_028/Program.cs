// На ввод принимает число и выдает количество цифр в числе

void SumNum(int num)
{
    int i = 1;
    for (i = 1; num > 10; i++)
    {
        num = num / 10;
    }
    Console.WriteLine($"количество цифр в числе: {i}");
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
SumNum(a);
