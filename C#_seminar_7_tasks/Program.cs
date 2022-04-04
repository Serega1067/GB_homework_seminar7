/*
Задача 1.
Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
*/

double[,] MakeArray()
{
    Console.WriteLine("Создадим двумерный массив");
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    while (m < 0)
    {
        Console.WriteLine("Вы ввели неверное значение меньше 0\n" +
                          "Введите количество строк: ");
        m = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (n < 0)
    {
        Console.WriteLine("Вы ввели неверное значение меньше 0\n" +
                          "Введите количество столбцов: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
            array[i, j] += new Random().NextDouble();
        }
    }
    return array;
}

void LookArray(double[,] argArray)
{
    Console.WriteLine("Получившийся массив: ");
    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            if (argArray[i, j] < 0) 
            {
                Console.Write("{0:0.0} ", argArray[i, j]);
            }
            else { Console.Write(" {0:0.0} ", argArray[i, j]); }
        }
        Console.WriteLine();
    }
}

double[,] resultArray = MakeArray();
LookArray(resultArray);

/*
Задача 2.
Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.
*/

/*
int[,] MakeArray()
{
    Console.WriteLine("Создадим двумерный массив\n" +
                      "Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[row, column];
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 100);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
*/

/*
void FindElemInArray(int[,] argArray)
{
    Console.WriteLine("\nЧтобы найти элемент в массиве\n" +
                      "Введите номер строки начиная с 1: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введите номер столбца начиная с 1: ");
    int column = Convert.ToInt32(Console.ReadLine()) - 1;
    if (row < argArray.GetLength(0) && column < argArray.GetLength(1))
    {
        Console.WriteLine($"Искомое значение: {argArray[row, column]}");
    }
    else Console.WriteLine("Такова элемента нет");
}

FindElemInArray(MakeArray());
*/

/*
Задача 3.
Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
*/

/*
void FindAverageValue(int[,] argArray)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < argArray.GetLength(1); j++)
    {
        double temp = 0;
        double averageValue = 0;
        for (int i = 0; i < argArray.GetLength(0); i++)
        {
            temp += argArray[i, j];
        }
        averageValue = temp / argArray.GetLength(0);
        if (j == argArray.GetLength(1) - 1)
        {
            Console.Write("{0:0.0}.", averageValue);
        }
        else { Console.Write("{0:0.0}; ", averageValue); }
    }
    Console.WriteLine();
}

// Метод создающий массив MakeArray() описан во 2 задаче.
int[,] array = MakeArray();
FindAverageValue(array);
*/
