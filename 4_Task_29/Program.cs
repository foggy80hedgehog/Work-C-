/* 
Напишите программу, которая задаёт массив и выводит его на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

все  элементы должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();

*/

Console.Clear();
Console.WriteLine ("Введите значения в массив через пробел");
string[] Mass=Console.ReadLine().Split(' ');
Console.WriteLine();
Console.WriteLine("Ваш массив: {0}",String.Join(",",Mass));             


