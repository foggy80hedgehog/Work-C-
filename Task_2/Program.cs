// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Наибольшее из двух чисел");

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "");

if (number1 > number2)
{
    Console.WriteLine();   
    Console.WriteLine($"{number1} > {number2}");     
}
if (number2 > number1)
{
    Console.WriteLine();   
    Console.WriteLine($"{number2} > {number1}");      
}
if(number2 == number1)
{
    Console.WriteLine();   
    Console.WriteLine($"{number2} = {number1}"); 
}