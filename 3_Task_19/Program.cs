/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Clear();
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число не пятизначное. Повторите ввод!");
        }
    }

    return result;
}

int x = GetNumber("Введите пятизначное число:");

if (x / 10000 == x % 10 && x % 10 % 10 % 10 == x % 10 % 10)
    Console.WriteLine("число является палиндромом");
else
{
    Console.WriteLine("число НЕ является палиндромом");
}