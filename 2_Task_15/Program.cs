/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/ 
 
Console.Clear(); 
Console.WriteLine("Програма выводит Выходной день или нет"); 
Console.WriteLine(); 
Console.WriteLine("Введите цифру, обозначающую день недели: "); 
int number =int.Parse (Console.ReadLine() ); 

if ( number > 5 && number < 8 )
    Console.WriteLine("да");


else if (number > 0 && number < 6) 
    Console.WriteLine("нет");

else 
    Console.WriteLine("Такого дня недели нет");
