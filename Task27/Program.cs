/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        int digit = number % 10;
        result = result + digit;
        number = number / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = SumOfDigits(num);
Console.WriteLine($"Сумма цифр числа {num} равна {res}");
