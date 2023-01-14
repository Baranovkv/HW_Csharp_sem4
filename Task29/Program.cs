// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.

int[] FillArray ()
{
    int [] array = new int [8];
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Enter {i+1} number of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
}

PrintArray(FillArray());