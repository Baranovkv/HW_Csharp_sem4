// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число 
// и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

int DigitCount(double number) // функция для решения только второй части задачи (HARD), возвращает количество цифр
{
    int count = 0;
    for (double i = Math.Abs(number); (i % 1) > 0; i = i * 10) // посчитали цифры справа от запятой
        count++;
    for (double i = Math.Abs(number); i > 1; i = i / 10) // посчитали цифры слева от запятой
        count++;
    return count;
}

void DigitCountSum(double number, int[] result) // общая функция для вычисления количества цифр и их суммы
{
    int count = 0; // счетчик цифр в числе
    int sum = 0; // сумма цифр в числе
    number = Math.Abs(number); // получаем модуль числа, чтобы работало с отрицательными числами
    while (number % 1 > 0) // сдвигаем число влево от запятой
        number = number * 10; 
    int numInt = Convert.ToInt32(number); // переводим в тип целого числа, чтобы создать массив из цифр
    for (int i = numInt; i > 0; i = i / 10) // считаем количество цифр в числе
        count++;
    int [] array = new int [count]; // создаем массив с размером по количеству цифр в числе
    for (int i = count-1; i >= 0; i--) // заполняем с конца массив цифрами-остатками от деления числа на 10
    {
        array[i] = numInt % 10;
        numInt = numInt / 10;
    }
    for (int i = 0; i < count; i++) // считаем сумму чисел в массиве
        sum += array[i];
    result[0] = count;
    result[1] = sum;
}

Console.WriteLine("Enter a number");
double num = Convert.ToDouble(Console.ReadLine());
int[] result = new int[2]; // массив для возврата счетчика и суммы из функции
DigitCountSum(num, result);
Console.WriteLine($"{result[0]} digits in the number. Digits summ is {result[1]}");

Console.WriteLine();
Console.WriteLine($"The number has {DigitCount(num)} digits"); // решение только второй части задачи