//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
 
//456 -> 5 
//782 -> 8 
//918 -> 1 
 
 
Console.Clear(); 
Console.WriteLine("вход трёхзначное число и на выходе показывает вторую цифру этого числа"); 
Console.WriteLine(); 
Console.WriteLine("Введите трехзначное число: "); 
int number =int.Parse (Console.ReadLine() ); 
 
if (number > 99 && number < 1000) 
   {  
    number = number / 10 % 10; 
    Console.WriteLine($"Вторая цифра вашего числа : {number}"); 
   } 
 
   else 
    Console.WriteLine("Неверное значение числа");