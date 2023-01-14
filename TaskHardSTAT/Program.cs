// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива, возможно придется кое-что для этого дополнительно выполнить.

void FillPrintArray(int[] fillArray) // fill the array with random numbers from 0 to 99 inclusive
{
    for (int i = 0; i < fillArray.Length; i++)
        fillArray[i] = new Random().Next(-100,101);
}


void PrintArray(int[] printArray) // fill the array with random numbers from 0 to 99 inclusive
{
    for (int i = 0; i < printArray.Length; i++)
        Console.Write(printArray[i]+" ");
    Console.WriteLine();
}


void SortMaxMinAver(int[] procArray, double[] MinMaxAverMed)
{
    int maxInd = 0;
    int minInd = 0;
    double average = 0;
    double mediana = 0;
    
    for (int i = 0; i < procArray.Length; i++) // find average
        average += procArray[i];
    average = average / procArray.Length;

    for (int i = 1; i < procArray.Length; i++) // find indexes of max and min
    {
        if (procArray[i] > procArray[maxInd])
            maxInd = i;
        else if (procArray[i] < procArray[minInd])
            minInd = i;
    }

    Console.Write("Sorted array:  ");
    for (int i = 0; i < procArray.Length-1; i++) // buble sort array
        for (int j = 1 + i; j < procArray.Length; j++)
            if (procArray[i] > procArray[j])
                (procArray[i], procArray[j]) = (procArray[j], procArray[i]); 

    if (procArray.Length % 2 > 0) // find mediana for odd number of array elements
        mediana = Convert.ToDouble(procArray[procArray.Length / 2]);
    else mediana = (procArray[procArray.Length / 2] + procArray[procArray.Length / 2 - 1]) / 2.0;
    MinMaxAverMed[0] = procArray[0];
    MinMaxAverMed[1] = minInd;
    MinMaxAverMed[2] = procArray[procArray.Length-1];
    MinMaxAverMed[3] = maxInd;
    MinMaxAverMed[4] = average;
    MinMaxAverMed[5] = mediana;
}

try // program body
{
    Console.WriteLine("Please enter array size");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [length];
    double[] result = new double [6];
    FillPrintArray(array);
    Console.Write("Created array: ");
    PrintArray(array);
    SortMaxMinAver(array, result);
    PrintArray(array);
    Console.WriteLine($"Minimal array element is {result[0]} with index {result[1]}");
    Console.WriteLine($"Maximum array element is {result[2]} with index {result[3]}");
    Console.WriteLine($"Average is {Math.Round(result[4], 2)}");
    Console.WriteLine($"Mediana is {Math.Round(result[5], 2)}");
}
catch
{
    Console.WriteLine("The array size must be integer");
}