// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter the first number: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number: ");
int B = int.Parse(Console.ReadLine()!);


void Product(int number, int power)
{
    int i = 1;
    int prod = 1;

    while (i <= B)
    {
        prod *= A;
        i++;
    }
    Console.Write($"The result of raising a number {A} to the power of {B} is {prod} ");
}
Product(A, B);