// Ввод цифры, обозначающей день недели, и проверяет будний/выходной

Console.Write("Напишите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 6 || x == 7)
{
    Console.WriteLine("Выходной");

    // if (x == 6)
    // {
    //     Console.WriteLine("Суббота");
    // }
    // if (x == 7)
    // {
    //     Console.WriteLine("Воскресенье");
    // }
}
else if (x >= 1 & x <= 5)
{
    Console.WriteLine("Работать))");
}
else if (x < 1 || x > 7)
{
    Console.WriteLine("Ты чё ввёл?");
}
// if (x == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
// if (x == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if (x == 3)
// {
//     Console.WriteLine("Среда");
// }
// if (x == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (x == 5)
// {
//     Console.WriteLine("Пятница");
// }

// else
//     Console.WriteLine("Ввели неверное значение");
