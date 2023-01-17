/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("ввели не число или меньше 1.");
        }
    }

    return result;
}

int Summa(int num)
{
    int summ = 0;
    int Length = num.ToString().Length;
    for (int i = 0; i < Length; i++)
    {
        summ += num % 10;
        num = num / 10;
    }
    return summ;
}


Console.Clear();
Console.WriteLine("Программа выдаёт сумму цифр в числе");
int number1 = GetNumber("Введите число больше 1");

int sumf = Summa(number1);

Console.WriteLine($"сумму цифр в числе {number1}   = {sumf}");