// На ввод число N, а на выходе таблицаквадратов этих чисел

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    Console.WriteLine(count * count);
    count++;
}
