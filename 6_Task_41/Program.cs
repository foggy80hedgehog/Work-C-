/*

Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/




Console.Clear();
Console.WriteLine("Введите значения в массив через пробел");
string[] Mass = Console.ReadLine().Split(' ');

Console.WriteLine();
Console.WriteLine("Ваш массив: {0}", String.Join(",", Mass));

int pozitivNumbers = 0;

for (int i = 0; i < Mass.Length; i++)
{
    int temp = int.Parse(Mass[i]);

    if (temp > 0)
    {
        pozitivNumbers++;
    }

}

Console.WriteLine();
Console.WriteLine($"Колличество чисел больше 0 = {pozitivNumbers}");


