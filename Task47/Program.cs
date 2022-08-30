// Задайте двумерный массив nxm, заполненный случайными вещественными числами
void PrintArray (double[,] array) 
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
double[,] CreateMatrixArray (int row, int column, int min, int max)
{
    var rnd = new Random();
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(min, max) + Math.Round(rnd.NextDouble(), 1);
        }
    }
    return array;
}
double[,] myArray = CreateMatrixArray(16,23,1,8);
PrintArray(myArray);