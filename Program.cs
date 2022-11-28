Task34();

Console.ReadKey();
Task36();

Console.ReadKey();
Task38();


void Task34()
{
    Console.WriteLine("\nЗадача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. " +
                        "Напишите программу, которая покажет количество чётных чисел в массиве.\nПример:" +
                        "\n[345, 897, 568, 234] -> 2");

    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] array = new int[size];

    FillIntArray(array, 100, 999);
    PrintIntArray(array);

    int count = FindEvenNumber(array);
    Console.WriteLine($"Количество чётных чисел в массиве -> {count}");
}

void Task36()
{
    Console.WriteLine("\nЗадача 36: Задайте одномерный массив, заполненный случайными числами. " +
                        "Найдите сумму элементов, стоящих на нечётных позициях.\nПримеры:" +
                        "\n[3, 7, 23, 12] -> 19\n[-4, -6, 89, 6] -> 0");

    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] array = new int[size];

    FillIntArray(array);
    PrintIntArray(array);

    int sum = FindSumOddIndexes(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {sum}");
}

void Task38()
{
    Console.WriteLine("\nЗадача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным " +
                            "и минимальным элементами массива.\nПример:" +
                            "\n[3 7 22 2 78] -> 76");

    int size = ReadIntFromConsole("Введите размер массива: ");
    double[] array = new double[size];

    FillDoubleArray(array);
    PrintDoubleArray(array);

    double max = Math.Round(array.Max(), 2);
    double min = Math.Round(array.Min(), 2);

    Console.WriteLine($"Разница между максимальным [{max}] и минимальным [{min}] элементами массива " +
                        $"-> {Math.Round((max - min), 2)}");
}


int ReadIntFromConsole(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillIntArray(int[] arr, int minVal = -99, int maxVal = 99)
{
    maxVal++;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }
}

void PrintIntArray(int[] arr)
{
    Console.Write($"Вывод массива: [");
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]\n");
}

int FindEvenNumber(int[] arr)
{
    int count = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int FindSumOddIndexes(int[] arr)
{
    int sum = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 1) sum += arr[i];
    }
    return sum;
}

void FillDoubleArray(double[] arr, int minVal = -99, int maxVal = 99)
{
    maxVal++;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal) * new Random().NextDouble();
    }
}

void PrintDoubleArray(double[] arr, int round = 2)
{
    Console.Write($"Вывод массива: [");
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{Math.Round(arr[i], round)}, ");
    }
    Console.Write("\b\b]\n");
}
