// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2dArray()
// {
//     Console.Write("Input numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] createdArray = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             createdArray[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);

//     return createdArray;        
// }

// void Show2dArray (double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }     
// }

// Show2dArray(Create2dArray());


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

// int[,] Create2dArray()
// {
//     int rows = new Random().Next(1, 5);
//     int columns = new Random().Next(1, 5);
//     int[,] createdArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             createdArray[i, j] = new Random().Next(-9, 10);

//     return createdArray;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// void FindElemFromPosition(int[,] array, int rowFind, int columnFind)
// {
//     if(rowFind < array.GetLength(0) && columnFind < array.GetLength(1))
//         Console.WriteLine($"There is your element with index [{rowFind}, {columnFind}]: {array[rowFind, columnFind]}");
//     else
//         Console.WriteLine($"There is not fond with your index [{rowFind}, {columnFind}] ");
// }

// Console.Write("Input number of row: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of column: ");
// int column = Convert.ToInt32(Console.ReadLine());

// if(row >= 0 && column >= 0)
// {
//     int[,] randArray = Create2dArray();
//     Show2dArray(randArray);
//     FindElemFromPosition(randArray, row, column);
// }
// else Console.WriteLine("Index cant be less than 0. Please input valid index.");


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] Create2dArray()
// {
//     int rows = new Random().Next(1, 5);
//     int columns = new Random().Next(1, 5);
//     int[,] createdArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             createdArray[i, j] = new Random().Next(0, 10);

//     return createdArray;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowArray (double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//             Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// double [] MediumNumColumns (int [,] array)
// {
//     int rowCount = array.GetLength(0);
//     int colCount = array.GetLength(1);
//     double [] midColArray = new double [colCount];
//     for (int j = 0; j < colCount; j++)
//     {     
//         double midSum = 0;  
//         for(int i = 0; i < rowCount; i++)
//         {
//             midSum += array[i, j];
//         }
//         midColArray[j] = Math.Round(midSum / rowCount, 1);
//     }
//     return midColArray;
// }

// int [,] randArray = Create2dArray();
// Show2dArray(randArray);
// ShowArray(MediumNumColumns(randArray));