// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

int Sum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum+=(num%10);
        num/=10;
    }
    return sum;
}

Console.Write($"The sum of digits in number {number} is {Sum(number)} ");


