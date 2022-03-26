/*
Задача 29: Напишите программу, которая задаёт массив из N(-100 100) 
рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateRandomArray(int length)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(-99, 100);
    }
    return returningArray; 
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < (arrayToPrint.Length - 1))
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(N);
PrintArray(array);
