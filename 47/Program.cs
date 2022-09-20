//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int height = EnterInt("введи количество строк в массиве: ");
int width = EnterInt("введи количество столбцов в массиве: ");

double[,] numbers = new double[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-99,100)/10.0);//нашел такой вариант (деление на 10.0(почему именно с нулем через точку?) и потом преобразовать в double), но он какой то костыльный на мой взгляд, можно ли лучше?
        }
    }
}

void Print2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],4} ");
        }
        Console.WriteLine();
    }
}