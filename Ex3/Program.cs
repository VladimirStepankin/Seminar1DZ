/*Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка)*/
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 2;
if (lastDigit == 0)
{
    Console.Write("Число " + number + " четное");
}
else
{
    Console.Write("Число " + number + " нечетное");
}