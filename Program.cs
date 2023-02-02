void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-100, 101) / 10.0;
        }
    }
}

Console.WriteLine("Создаю двумерный массив вещественных чисел 3х4:");
double[,] array = new double[3, 4];
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Заполняю массив случайными числами в диапазоне от -10 до 10:");
FillArray(array);
PrintArray(array);
