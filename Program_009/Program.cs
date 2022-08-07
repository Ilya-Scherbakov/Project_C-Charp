// Ввести число N, и показать все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
count++;
}
