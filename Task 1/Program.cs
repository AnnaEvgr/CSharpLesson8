/*Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочивает 
по убыванию элементы каждой строки двумерного массива.*/

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Descending(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

System.Console.WriteLine("Сгенерированный массив: ");
System.Console.WriteLine();
int [,] matrix = new int [3,3];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
System.Console.WriteLine("Убывающий массив: ");
System.Console.WriteLine();
Descending(matrix);
PrintArray(matrix);