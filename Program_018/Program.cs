// See https://aka.ms/new-console-template for more information

int ProverkaChisla(int chislo)
{
    int colChisel = 0;
    while (chislo > 0)
    {
        chislo = chislo / 10;
        colChisel++;
    }
    return colChisel;
}

int number = 123456;
int sumchislo = ProverkaChisla(number);
int control = sumchislo - 3;
int i = 0;

if (sumchislo >= 3)
{
    while (i < control)
    {
        number = number / 10;
        i++;
    }
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра: {thirdNumber}");

}
if (sumchislo < 3)
{
    Console.WriteLine($"Нету цифирки");

}
