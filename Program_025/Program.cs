// На вход принимает координаты двух точек и находит расстояние между ними в 3D
Console.Write("Введите координату X точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
Console.WriteLine($"промежуточный результат: {d.ToString("F" + 2)}");
