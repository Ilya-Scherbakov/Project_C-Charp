// На ввод число N, а на выходе таблица кубов этих чисел

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}
