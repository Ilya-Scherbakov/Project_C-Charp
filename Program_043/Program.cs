// 43: Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void intersectionLines(int a, int b, int c, int d)
{
    if (a == c && b == d) Console.WriteLine("Прямые совпадают))");
    else if (a == c && b != d) Console.WriteLine("Прямые паралельны");
    else
    {
        double x = (b - d) / (c - a);
        double y = a * ((b - d) / (c - a)) + b;
        Console.WriteLine($"Точка пересечения [{x}, {y}]");
    }
}


Console.WriteLine("Введите занчение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите занчение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите занчение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите занчение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
intersectionLines(b1, k1, b2, k2);