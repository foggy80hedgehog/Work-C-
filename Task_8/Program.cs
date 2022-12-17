// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int count = 1;
Console.Clear();
Console.WriteLine("Программа покажет все четные числа от 1 до вашего числа");
Console.WriteLine();

Console.WriteLine("Введите ваше число, оно не должно быть меньше 2");
int number = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();
if(number < 2)
{
    Console.WriteLine("Неверное число");
}
else
{
    while(count <= number)
    {
        if(count % 2 == 0)
        {
            Console.Write($"{count}, ");
            count++;
        }
        else
            count++;

    }
}

