// Ввод цифры, обозначающей день недели, и проверяет будний/выходной

Console.Write("Напишите число: ");
int x = Convert.ToInt32(Console.ReadLine());

// Первый вариант решения

if (x == 6 || x == 7)
{
    Console.WriteLine("Выходной");
}
else if (x >= 1 & x <= 5)
{
    Console.WriteLine("Работать))");
}
else if (x < 1 || x > 7)
{
    Console.WriteLine("Ты чё ввёл?");
}
else
    Console.WriteLine("Ввели неверное значение");

// // второй вариант решения!
// if (x > 0)
// {
//     if (x<8)
//     {
//         if (x==6)
//         {
//             Console.WriteLine("Выходной");
//         }
//         else if (x == 7)
//         {
//             Console.WriteLine("Выходной");
//         }
//         else
//         {
//             Console.WriteLine("Будний день");
//         }    
//     }
//     else
//     {
//         Console.WriteLine("Ввели неверное значение");
//     }
// }
// else
// {
//     Console.WriteLine("Ввели неверное значение");
// }