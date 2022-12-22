/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/ 
 
Console.Clear(); 
Console.WriteLine("Програма выводит третью цифру заданного числа"); 
Console.WriteLine(); 
Console.WriteLine("Введите число: "); 
int number =int.Parse (Console.ReadLine() ); 
 
if (number > 99 ) 
   {  
    int i = 0;            // Вычисляем кол-во цифр в числе
    int count = number;
    int del = 1;
    while(count >0) 
        {
            count = count / 10;
            i ++;
            del = del * 10;
        }
     
        del = del / 1000; 
    
    int result = number / del % 10;
    Console.WriteLine($"Третья цифра вашего числа : {result}");
   } 
 
   else 
    Console.WriteLine("третьей цифры нет");