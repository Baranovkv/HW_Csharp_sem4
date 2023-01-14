// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitArray(int num) // создаем массив из цифрв числа и считаем их сумму
{
    num = Math.Abs(num); // получаем модуль числа, чтобы работало с отрицательными числами
    int count = 0;
    int sum = 0;
    for (int i = num; i > 0; i = i / 10) count++; // считаем разрядность введенного числа в переменную count
    int [] array = new int [count]; // создаем массив с разрядностью числа
    for (int i = count-1; i >= 0; i--) // заполняем массив с конца путем сохранения остатков от деления числа на 10
    {
        array[i] = num % 10;
        num = num / 10;
    }
    for (int i = 0; i < count; i++)
        sum += array[i];
    return sum;
}

Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigitArray(num));