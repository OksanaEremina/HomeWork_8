// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

    int[,,] array3D = new int[2, 2, 2];
    FillArray(array3D);
    PrintIndex(array3D);

    void PrintIndex(int[,,] arr)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int a = 0; a < array3D.GetLength(2); a++)
                {
                    Console.Write($"{array3D[i, j, a]}({i},{j},{a}) ");
                }
            }
        }
    }
    void FillArray(int[,,] arr)
    {
        int count = 10;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int a = 0; a < arr.GetLength(2); a++)
                {
                    arr[a, i, j] += count;
                    count += 3;
                }
            }
        }
    }
