void Task54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, которая 
    // упорядочит по убыванию элементы каждой строки двумерного массива.
    Console.WriteLine();
    Console.WriteLine("Задача № 54: ");
    Console.WriteLine();
    int[,] array = new int[4,5];
    FillArray(array, 0, 20);
    PrintArray(array);

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = columns - 1; k > j; k--)
            {
                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                     array[i, k - 1] = temp;
                }
            }
        }
    }
    PrintArray(array);
    Console.WriteLine("___________________________");    
}

void Task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    // которая будет находить строку с наименьшей суммой элементов.

    Console.WriteLine();
    Console.WriteLine("Задача № 56: ");
    Console.WriteLine();
    int[,] array = new int[4,5];
    FillArray(array, 0, 20);
    PrintArray(array);

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = columns - 1; k > j; k--)
            {
                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                     array[i, k - 1] = temp;
                }
            }
        }
    }

    PrintArray(array);
    Console.WriteLine();
    int sumMin = 0;
    int IndexMin = 0;
    for (int j = 0; j < columns; j++)
    {
        sumMin += array[0, j];
    }
    Console.WriteLine($"Сумма элементов {IndexMin + 1} строки равна {sumMin }");
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j]; 
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки равна {sum}");
        if (sum < sumMin)
        {
            sumMin = sum;
            IndexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов находится в строке {IndexMin + 1} и равна {sumMin}");
    Console.WriteLine("___________________________");    
}

void Task58()
{
// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
    Console.WriteLine();
    Console.WriteLine("Задача № 58: ");
    Console.WriteLine();
    int raws = 4;
    int columns = 4;
    int[,] array = new int[raws, columns];

    int IndexRaws = 0;
    int IndexColumns = 0;

    int ChangeRaws = 0;
    int ChangeColumns = 1;

    int steps = columns;
    int rotate = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[IndexRaws, IndexColumns] = i + 1;
        // Console.Write(array[IndexRaws, IndexColumns] + "\t");
        steps--;
        
        if (steps == 0)
        {
            steps = raws - 1 - rotate/2;
            int temp = ChangeRaws;
            ChangeRaws = ChangeColumns;
            ChangeColumns = -temp; 
            rotate++;
        }

        IndexRaws += ChangeRaws;
        IndexColumns += ChangeColumns; 

    }
PrintArray(array);

}

void FillArray (int[,] array, int LeftBorder = 0, int RightBorder = 1)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    RightBorder++;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(LeftBorder, RightBorder);
        }
    }
}

void PrintArray(int[,] currentArray)                                           
{
    Random random = new Random();
    int rows = currentArray.GetLength(0);
    int columns = currentArray.GetLength(1);
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Решение задач:

Task54();
Task56();
Task58();