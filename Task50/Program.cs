// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента или же указание, что такого элемента нет.
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
void SearchElement (int element, int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                Console.WriteLine($"Элемент {element} находится в массиве");
                return;
            }
        }
    }
    Console.WriteLine($"Элемент {element} не существует в данном массиве");
}
int[,] myArray = CreateMatrixArray(3,4,1,8);
PrintArray(myArray);
SearchElement(7, myArray);
SearchElement(10, myArray);