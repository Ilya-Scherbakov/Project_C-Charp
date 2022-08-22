// ПРИМЕР РАБОТЫ СО СТРОКАМИ

// string str = "Giv me string"; // сделал строку str
// Console.WriteLine(str); // тут просим вывести строку с названием str

// Console.WriteLine(str[1]); // тут просим вывести строку(она типо сейчас массив) показать с 1 индексом
// и покажет она нам букву i

// Console.WriteLine(str.Length); // тут просим показать длину строки(она типо сейчас массив) будет 13

// string str2 = "Good bye"; // создадим вторую строку
// string str3 = str + str2; // создал третью и хочу сложить предыдущие две (МЕТОД КОНКОТИНАЦИИ)
// //string str3 = string.Concat(str, ', ', str2); // МОЖНО ТАК СКЛЕИВАТЬ
// Console.WriteLine(str3);

int[] values = new int[] { 1, 2, 3, 4, 5, 6 }; // создал новый массив values
string str4 = string.Join("*", values); // хочу вывести на экран все что у меня тут есть
Console.WriteLine(str4); // покажет так 1*2*3*4*5*6