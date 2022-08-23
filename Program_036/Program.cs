// 33. Определяет присутствует ли определенное число в массиве

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($" {array[i]}");
    
}
Console.WriteLine();
Console.WriteLine("Напишите циферку:");
int num = Convert.ToInt32(Console.ReadLine());
bool start = false;
for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
        {
            start = true;
        }
}

if (start == true)
Console.Write("Данное число есть");
else
Console.Write("Нет");
