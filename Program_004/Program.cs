// Программа на вход принимает одно число а на выходе показывает в промежутке от -n до n

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0 - a;

while (b <= a)
{
    Console.Write(b);
    Console.Write(" ");
    b++;
}
