// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Random r = new Random();

Console.WriteLine("Введите колличество строк и столбцов: ");
int line = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[line, columns];
Console.WriteLine("Массив");
for (int i = 0; i < mass.GetLength(0); i++)//заполняем массив
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = r.Next(1, 10);
        Console.Write($"{mass[i, j]}\t");
    }
    Console.WriteLine();
}

void OrderArrayLines(int[,] array)
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


void PrintArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

OrderArrayLines(mass);
Console.WriteLine("Отсортиврованный массив");
PrintArray(mass);

