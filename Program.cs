/*
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int [,] FillArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void ShowArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] BubbleShuffleArray2D (int[,] array)
{
    int[] currentRowArray = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentRowArray[j] = array[i,j];
        }
        int temp;
        for (int j = 0; j < currentRowArray.Length; j++)
        {
            for (int k = 0; k < currentRowArray.Length - 1; k++)
            {
                if (currentRowArray[k] > currentRowArray[k + 1])
                {
                    temp = currentRowArray[k];
                    currentRowArray[k] = currentRowArray[k + 1];
                    currentRowArray[k + 1] = temp;
                }
            }
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = currentRowArray[j];
        }
    }
    return array;
}

Console.WriteLine("Укажите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] userArray = new int [rows, columns];

Console.WriteLine();

FillArray2D(userArray);
Console.WriteLine("Исходный массив:");
ShowArray2D(userArray);
Console.WriteLine();
userArray = BubbleShuffleArray2D(userArray);
Console.WriteLine("Упорядоченный массив:");
ShowArray2D(userArray);
Console.WriteLine();
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] FillArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void ShowArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void findMinSumRowNumber (int[,] array, int rows)
{
    int[] rowSumAr = new int [rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum = rowSum + array[i, j];
        }
        rowSumAr[i] = rowSum;
    }
    int minSum = rowSumAr[1];
    int minSumRowNumber = 0;
    for (int i = 0; i < rowSumAr.Length; i++)
    {
        if (rowSumAr[i] < minSum) { minSum = rowSumAr[i]; }
    }
    for (int i = 0; i < rowSumAr.Length; i++)
    {
        if (rowSumAr[i] == minSum) { minSumRowNumber = i; }
    }
    Console.WriteLine("\nСтрока с минимальной суммой символов (нумерация с нуля): " + minSumRowNumber);
}
Console.WriteLine("Укажите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] userArray = new int [rows, columns];

Console.WriteLine();

FillArray2D(userArray);
ShowArray2D(userArray);
findMinSumRowNumber(userArray, rows);
*/

/*
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] FillArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void ShowArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication (int[,] array1, int[,] array2)
{
    int[,] Multiplication = new int [array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int tempMultiplicationOfElement;
        int[] tempMultiplicationOfElementArray = new int [array1.GetLength(1)];
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            tempMultiplicationOfElement = array1[i,j] * array2[j,i];
            tempMultiplicationOfElementArray[j] = tempMultiplicationOfElement;
        }
        for (int k = 0; k < tempMultiplicationOfElementArray.Length; k++)
        {  
            Multiplication[i,k] = Multiplication[i,k] + tempMultiplicationOfElementArray[k];
        }
    }
    return Multiplication;
}

Console.WriteLine("Введите количество столбцов/строк согласованных матриц (число строк одной матрицы равно числу столбцов второй матрицы):");
int rowsAndColumnsQuantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] userArray1 = new int [rowsAndColumnsQuantity, rowsAndColumnsQuantity];
int[,] userArray2 = new int [rowsAndColumnsQuantity, rowsAndColumnsQuantity];

FillArray2D(userArray1);
FillArray2D(userArray2);

Console.WriteLine("Сгенерированные матрицы:");
ShowArray2D(userArray1);
Console.WriteLine();
ShowArray2D(userArray2);
Console.WriteLine();

Console.WriteLine("Произведение матриц:");
int[,] userArraysMultiplication = Multiplication(userArray1, userArray2);

ShowArray2D(userArraysMultiplication);
*/

/*
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] FillArray3D (int[,,] array, int[] mixedArray)
{
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++, l++)
            {
                array[i,j,k] = mixedArray[l];
            }
        }
    }
    return array;
}

int[] ShuffleArray ()
{
    int[] numbers = new int [90] {10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99};
    Random random = new Random();
 
    for (int i = numbers.Length - 1; i >= 1; i--)
    {
        int j = random.Next(i + 1);
 
        int temp = numbers[j];
        numbers[j] = numbers[i];
        numbers[i] = temp;
    }
    return numbers;
}

void ShowArray3D (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество элементов 1-го измерения:");
int dimension1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов 2-го измерения:");
int dimension2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов 3-го измерения:");
int dimension3 = Convert.ToInt32(Console.ReadLine());

int[,,] userArray = new int [dimension1, dimension2, dimension3];
int[] mixedArray = ShuffleArray();

FillArray3D(userArray, mixedArray);
ShowArray3D(userArray);
*/