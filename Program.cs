/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


public class MainClassh
{
    public static void Main()
    {
    int number = int.Parse(Console.ReadLine());
    Console.Write(number / 10 % 10);
    }
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


public class MainClassh
{
    public static void Main()
    {
    int number_day = ReadInt("Введите число: ");
    Console.WriteLine(Work_Holiday(number_day));
    int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string Work_Holiday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write(a + " - Выходной");
        }
        else
        {
            Console.Write(a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день недели.";
}
    }
}

