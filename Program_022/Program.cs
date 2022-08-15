// Принимает на вход координаты двух точек и находит расстояние между ними в 2D
Console.Write("Введите координату X точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2));  // Math.Pow(),2 - формула степени, через "," указывается в какую степень
                                                                      // Math.Sqrt() - формула квадратного корня
Console.WriteLine($"Расстояние: {d.ToString("F" + 2)}"); // ToString("F" + 2) - комнда округления до 2го знака по математическим законам        