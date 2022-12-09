// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Enter the length of the array ");
int N = int.Parse(Console.ReadLine());

int[] Massive(int length)

{
    int[] array = new int[length];
    int i = 0;

    while (i < length)
    {
        int ArrayElement = new Random().Next(0, 101);
        array[i] = ArrayElement;
        i++;
    }
    return array;
}

void PrintArray(int [] initArray)
{
    int length = initArray.Length;
    int i = 0;

    while (i < length)
    {

    if (i == 0)
        {
            Console.Write("[ " + initArray[i] + ", ");
        }
        if (i == length - 1)
        {
            Console.Write(initArray[i] + " ]");
        }
        if (i >0 && i < length - 1) 
        {
            Console.Write(initArray[i] + ", ");
        }
        i++;
    }
}

PrintArray(Massive(N));