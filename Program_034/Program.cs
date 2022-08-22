// Задать массив из 12 эл-ов в промежутке [-9, 9] и найти сумму отрицательных и положительных элементов

int[] str = new int[12];
int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < str.Length; i++)
{
    str[i] = new Random().Next(-9, 10);
    Console.Write($" {str[i]}");
    if(str[i] >= 0)
    {
        sumPositive = str[i] + sumPositive; // sumPositive += str[i] можно так написать
        
    }
    else
    {
        sumNegative = str[i] + sumNegative; // sumNegative += str[i] можно так написать
        
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных: {sumPositive}");
Console.WriteLine($"Сумма отрицательных: {sumNegative}");