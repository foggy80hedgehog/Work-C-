/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 
*/ 
 
Console.Clear(); 
int GetNumber(string message) 
{ 
int result = 0; 
 
while(true) 
{ 
Console.WriteLine(message); 
 
if(int.TryParse(Console.ReadLine(), out result) && result > 0) 
{ 
break; 
} 
else 
{ 
Console.WriteLine("Ввели не число или число не из заданного диапазона. Повторите ввод!"); 
} 
} 
 
return result; 
} 

Console.WriteLine("выдаёт таблицу кубов, чисел от 1 до вашего числа");  
int N = GetNumber("Введите число больше 0:"); 
int Cont = 1; 
while (Cont <= N) 
{      
    double result = Math.Pow( Cont, 3); 
    Cont++; 
    Console.Write($"{result} "); 
}