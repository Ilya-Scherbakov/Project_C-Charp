// Программа вводит случайное стрехзначное число и удаляет вторую цифру напр: 238 -> 28

int num = new Random().Next(100, 1000);

// Первый способ
// int a = num / 100;
// int b = (num - a * 100) / 10;
// int c = num % 10; // остаток при делении на десять. Допустим 123 / 10 = 12,3, значит запишет 3

// Console.WriteLine($"Число: {num}. Первая цифра: {a}, Вторая цифра: {b}, Третья цифра: {c}.");
// Console.WriteLine($"{a}{c}");

//Второй способ (я не понял)
Console.WriteLine(num);
int result = num / 100 * 10 + num % 10;
Console.WriteLine(result);