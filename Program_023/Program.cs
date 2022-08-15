// На вход число N и выдает таблицу квадратов чисел

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
sum = 1;

while (sum <= n)
{
    Console.WriteLine(sum * sum);
    sum++;
}
Console.WriteLine();