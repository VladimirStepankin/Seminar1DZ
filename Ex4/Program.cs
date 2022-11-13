/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N*/
Console.Write("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
if (number > 0)
{
    while (a < number)
    {
        int b = a % 2;
        if (b == 0)
        {
            Console.Write(a + " ");
        }
        a++;
    }
}
else
{
    Console.Write("Вы ввели не натуральное число");
}