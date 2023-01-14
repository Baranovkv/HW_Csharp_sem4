// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Power(double number, int power)
{
    double PowNum = 1;
    for (int i = 0; i < power; i++)
        PowNum = PowNum * number;
    return PowNum;
}

Console.WriteLine("Please enter number (A)");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter a power of number (B)");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The power {pow} of the number {num} is {Power(num, pow)}");