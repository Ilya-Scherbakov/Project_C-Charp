// Ввести число и посчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Способ 1
// int result = 0;
// while (num > 0)
// {
//     result = num % 10 + result;
//     num = num / 10;
// }
// Console.WriteLine(result);

// Способ 2
void Trololo(int x)
{
    int sum = 0;
    for (sum = 0; x > 0; x = x / 10)
    {
        sum = sum + x % 10;
    }
    Console.WriteLine($"Сумма цифр числа равна: {sum}"); 
}
Trololo(num); // как прописать ($"Сумма цифр числа {num} равна: {sum}"); ???????

// Способ 3    перевести в массив и сложить эл-ты  НЕ РЕШИЛ(((((
// int Trololo(int arr)
// {
    
//     int result = 0;
//     int i = 0;
//     for (int length = arr.Length; i < length; i++)
//     {
//         result = result + arr[i];
//     }
//     Console.WriteLine($"Сумма цифр числа равна: {result}");
// }
// Trololo(num);