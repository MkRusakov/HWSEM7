// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void PrintArray (int[,] array) 
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] CreateMatrixArray (int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max+1);
        }
    }
    return array;
}
void AverageValue (int[,] array, int column)
{
    double sum = 0; // Если поменять тип sum с double на int, result будет int. Почему? У меня же result и так double.
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = (sum + array[i, column]);
        result = Math.Round(sum / array.GetLength(0), 1);
    }
    Console.WriteLine($"Среднее арифметическое столбца {column} - {result}");
    AverageValue(array, column+1);
    if (column > array.GetLength(1)) return;
} 
int[,] myArray = CreateMatrixArray(3,4,1,8);
PrintArray(myArray);
Console.WriteLine();
AverageValue(myArray, 0);
