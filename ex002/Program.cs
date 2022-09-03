//Задача 56:  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int SummaLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

Random r = new Random();
Console.WriteLine("Введите колличество строк и столбцов: ");
int line = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[line, columns];
{
  for (int i = 0; i < mass.GetLength(0); i++)
  {
      for (int j = 0; j < mass.GetLength(1); j++)
      {
          mass[i, j] = r.Next(1, 10);
          Console.Write($"{mass[i, j]}\t");
      }
    Console.WriteLine();
  }
}

int minSumLine = 0;
int sumLine = SummaLineElements(mass, 0);
for (int i = 1; i < mass.GetLength(0); i++)
{
    int temp = SummaLineElements(mass, i);
    if (sumLine > temp)
    {
        sumLine = temp;
        minSumLine = i;
    }
}

Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

