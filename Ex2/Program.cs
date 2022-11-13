/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел*/

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.Write("max = " + a);
    }
    else 
    {  
        Console.Write("max = " + c);
    }        
}
else
{
    if (b > c)
    {
        Console.Write("max = " + b);
    }
    else 
    {  
        Console.Write("max = " + c);
    } 
}