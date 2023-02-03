// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 99)
{
    while(num > 999)
    {
        num /= 10;
    }
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цыфры нет");
}