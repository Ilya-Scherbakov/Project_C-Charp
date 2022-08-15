// На ввод принимает координаты точки (X и Y), причем х=!0 и у=!0, и выдает номер четверти плоскости в которой находится
Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x == 0) || y == 0)
{
    Console.WriteLine("Не может быть равен нулю");
}

else if ((x > 0) && (y > 0))
{
    Console.WriteLine("Точка в первой четверти");
}
else if ((x < 0) && (y > 0))
{
    Console.WriteLine("Точка во второй четверти");
}
else if ((x < 0) && (y < 0))
{
    Console.WriteLine("В третей четверти");
}
else if ((x > 0) && (y < 0))
{
    Console.WriteLine("В четвертой четверти");
}

