/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число дня:");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5)
{
    Console.WriteLine("Рабочий");
}
else if (day >= 6 && day <= 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Введите число дня:");
}