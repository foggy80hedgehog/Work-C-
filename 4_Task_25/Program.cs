/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

double GetStep(int num1, int num2)
{
double step = Math.Pow(num1, num2);

return step;
}

Console.Clear();
Console.WriteLine("Программа возводит число A в натуральную степень B");
int number1 = GetNumber("Введите число А, больше 1");
int number2 = GetNumber("Введите число В, больше 1");


double summ = GetStep(number1,number2);

Console.WriteLine($"Число {number1} возведенное в степень {number2} = {summ}");