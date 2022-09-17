// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

    Console.WriteLine("Ввести количество строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввести количество столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine();
    Console.WriteLine("Массив");
    PrintArray(numbers);

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int a = 0; a < numbers.GetLength(1) - 1; a++)
            {
                if (numbers[i, a] < numbers[i, a + 1]) 
                {
                    int temp = 0;
                    temp = numbers[i, a];
                    numbers[i, a] = numbers[i, a + 1];
                    numbers[i, a + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив по убыванию значений");
    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine("");
        }
    }