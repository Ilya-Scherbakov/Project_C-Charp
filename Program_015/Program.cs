// На ввод принимает трехзначное число и показывает вторую цифру. Напр: 235 -> 3

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int x = num / 10 - ((num / 100) * 10);

Console.WriteLine($"Второе число будет: {x}");
