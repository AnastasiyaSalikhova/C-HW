// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

 Console.Write("Введите цыфру дня недели ");
 int num = int.Parse(Console.ReadLine()!);

 while(num < 1 || num > 7)
 {
    Console.Write("Введите цыфру от 1 до 7: ");
    num = int.Parse(Console.ReadLine()!);
 }
 if(num == 6 || num ==7)
 {
    Console.WriteLine("Да");
 }
 else
 {
    Console.WriteLine("Нет");
 }