// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// // элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] Fill2dArray(int rows, int cols, int min, int max)
// {
//    int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }


// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] SortArrayRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         bool sorted = false;
//         while(!sorted){
//             sorted = true;
//             for (int j = 0; j < array.GetLength(1)-1; j++)
//             {
//                 int temp = array[i,j];
//                     if(array[i,j+1]>temp){
//                     array[i,j] = array[i,j+1];
//                     array[i,j+1] = temp;
//                     sorted = false;
//                 }
//             }
//         }
//     }
//     return array;
// }


// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt16(Console.ReadLine());
// Console.Write("Enter number of columnss: ");
// int cols = Convert.ToInt16(Console.ReadLine());
// int min = 0;
// int max = 9;

// if(rows<1 || cols<1) Console.WriteLine("Numbers of rows & columns must be greater than 0");
// else
// {
//     int[,] array = Fill2dArray(rows, cols, min, max);
//     Print2dArray(array);
//     int[,] arraySort = SortArrayRows(array);
//     Print2dArray(arraySort);
// }




// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// // находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7

// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// // наименьшей суммой элементов: 1 строка

// int[,] Fill2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }


// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void MinSumRow(int[,] array)
// {
//     int minSum = 0;
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] = sum[i] + array[i, j];
//         }
//     }
//     int minimal = sum[0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         if (sum[i] < minimal) minSum = i;
//         Console.Write($"{sum[i]}  ");
//     }
//     Console.WriteLine();
//     Console.WriteLine($"The row with minimal summ is {minSum + 1} ");
// }


// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt16(Console.ReadLine());
// Console.Write("Enter number of columnss: ");
// int cols = Convert.ToInt16(Console.ReadLine());
// int min = 0;
// int max = 9;

// if (rows < 1 || cols < 1) Console.WriteLine("Numbers of rows & columns must be greater than 0");
// else
// {
//     int[,] array = Fill2dArray(rows, cols, min, max);
//     Print2dArray(array);
//     MinSumRow(array);
// }






// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int[,] Fill2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }


// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,] MultiplyMatrix(int[,] ar1, int[,] ar2)
// {
//     int[,] result = new int[ar1.GetLength(1), ar1.GetLength(1)];

//     for (int i = 0; i < ar1.GetLength(0); i++)
//     {   
        
//         for (int j = 0; j < ar1.GetLength(1); j++)
//         {
//             result[i,j] = result[i,j]+ar1[i,j]*ar2[j,i];
//         }
        
//     }
//     return result;
// }


// int min = 1;
// int max = 6;

// Console.Write("Enter number of rows for the 1st matrix: ");
// int rows1 = Convert.ToInt16(Console.ReadLine());
// Console.Write("Enter number of columns for the 1st matrix: ");
// int cols1 = Convert.ToInt16(Console.ReadLine());

// if (rows1 < 1 || cols1 < 1) Console.WriteLine("Numbers of rows & columns must be greater than 0");
// else
// {
//     Console.WriteLine($"For the second matrix automatically: {cols1} rows and {rows1} columns");
//     int[,] arr1 = Fill2dArray(rows1, cols1, min, max);
//     Print2dArray(arr1);
//     int[,] arr2 = Fill2dArray(cols1, rows1, min, max);
//     Print2dArray(arr2);
//     Print2dArray(MultiplyMatrix(arr1,arr2));

// }



// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

// int[,,] Fill3dArray(int rows, int cols, int depth)
// {
//     int[,,] array = new int[rows, cols, depth];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             for (int z = 0; z < depth; z++)
//             {
//               array[i, j, z] = new Random().Next(10,100);  
//             }
//         }
//     }
//     return array;
// }

// void Print3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                Console.Write($"{array[i, j, z]}[{i},{j},{z}] "); 
//             }
//             Console.WriteLine();
//         }
        
//     }
//     Console.WriteLine();
// }

// int a = 2;
// int b = 2;
// int c = 2;

// Print3dArray(Fill3dArray(a,b,c));


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiralArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    int start = 101;
    int count = 0;
    
    for (int i = 0+count; i < rows-count; i++)
    {
        for (int j = 0+count; j < cols-count; j++)
        {
            array[i,j] = start;
            Console.WriteLine(array[i,j]+ " " + start + " " + i+ " " + j);
            Console.WriteLine();
            start++;

            for (i = 1+count; i < rows-count-1; i++) //
            {
                array[i,j] = start;
                start++;
                
                for ( j = cols-count-1; j >=0+count; j--)
                {
                    array[i,j] = start;
                    start++;
                   // count++;
                   for (i = rows-count-1; i >= 0+count; i--)
                   {
                    array[i,j] = start;
                    start++;
                    count++;
                   }
                }
                
            }
        }
    }
    return array;
}



void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = 4;
int cols = 4;

Print2dArray(FillSpiralArray(rows, cols));