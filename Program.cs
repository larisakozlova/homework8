// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

        // int[,] arr = new int[,]
        // {
        //     {3, 7, 4, 9},
        //     {1, 2, 3, 4},
        //     {5, 6, 7, 8}
        // };

        // int rows = arr.GetLength(0);
        // int cols = arr.GetLength(1);

        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < cols - 1; j++)
        //     {
        //         for (int k = 0; k < cols - j - 1; k++)
        //         {
        //             if (arr[i, k] < arr[i, k + 1])
        //             {
        //                 int temp = arr[i, k];
        //                 arr[i, k] = arr[i, k + 1];
        //                 arr[i, k + 1] = temp;
        //             }
        //         }
        //     }
        // }

        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < cols; j++)
        //     {
        //         Console.Write(arr[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }


//     Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//     находить строку с наименьшей суммой элементов.

//     Например, задан массив:
//     1 4 7 2 
//     5 9 2 3
//     8 4 2 4 
//     5 2 6 7

//  Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей 
//  суммой элементов: 1 строка

// int[,] array = {
//             { 7, 8, 4, 9 },
//             { 5, 9, 2, 3 },
//             { 1, 2, 3, 4 },
//             { 5, 2, 6, 7 }
//         };

//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         int minSum = int.MaxValue;
//         int minSumRowIndex = 0;

//         for (int i = 0; i < rows; i++)
//         {
//             int rowSum = 0;

//             for (int j = 0; j < cols; j++)
//             {
//                 rowSum += array[i, j];
//             }

//             if (rowSum < minSum)
//             {
//                 minSum = rowSum;
//                 minSumRowIndex = i;
//             }
//         }

//         Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRowIndex + 1));


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
    

    //  int[,] matrix1 = {
    //         { 2, 3},
    //         { 3, 4 }
    //     };

    //     int[,] matrix2 = {
    //         { 3, 5},
    //         { 3, 6}
    //     };

    //     int rows1 = matrix1.GetLength(0);
    //     int cols1 = matrix1.GetLength(1);
    //     int rows2 = matrix2.GetLength(0);
    //     int cols2 = matrix2.GetLength(1);

    //     if (cols1 != rows2)
    //     {
    //         Console.WriteLine("Умножение матриц невозможно!");
    //         return;
    //     }

    //     int[,] result = new int[rows1, cols2];

    //     for (int i = 0; i < rows1; i++)
    //     {
    //         for (int j = 0; j < cols2; j++)
    //         {
    //             for (int k = 0; k < cols1; k++)
    //             {
    //                 result[i, j] += matrix1[i, k] * matrix2[k, j];
    //             }
    //         }
    //     }

    //     Console.WriteLine("Результирующая матрица:");

    //     for (int i = 0; i < rows1; i++)
    //     {
    //         for (int j = 0; j < cols2; j++)
    //         {
    //             Console.Write(result[i, j] + " ");
    //         }
    //         Console.WriteLine();
    //     }


//     Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//     которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


//  int[,,] array = new int[2, 2, 2];

//         int value = 10;

//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 for (int k = 0; k < 2; k++)
//                 {
//                     array[i, j, k] = value;
//                     value += 1;
//                 }
//             }
//         }

//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 for (int k = 0; k < 2; k++)
//                 {
//                     Console.WriteLine(array[i, j, k] + "(" + i + "," + j + "," + k + ")");
//                 }
//             }
//         }



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//   int[,] array = new int[4, 4];

//         int value = 1;
//         int minRow = 0;
//         int maxRow = 3;
//         int minCol = 0;
//         int maxCol = 3;

//         while (value <= 16)
//         {
//             // Вправо
//             for (int i = minCol; i <= maxCol; i++)
//             {
//                 array[minRow, i] = value;
//                 value++;
//             }
//             minRow++;

//             // Вниз
//             for (int i = minRow; i <= maxRow; i++)
//             {
//                 array[i, maxCol] = value;
//                 value++;
//             }
//             maxCol--;

//             // Влево
//             for (int i = maxCol; i >= minCol; i--)
//             {
//                 array[maxRow, i] = value;
//                 value++;
//             }
//             maxRow--;

//             // Вверх
//             for (int i = maxRow; i >= minRow; i--)
//             {
//                 array[i, minCol] = value;
//                 value++;
//             }
//             minCol++;
//         }

//         for (int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 4; j++)
//             {
//                 Console.Write(array[i, j].ToString("D2") + " ");
//             }
//             Console.WriteLine();
//         }
    





