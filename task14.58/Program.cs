/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("введите кол-во строк матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [n,m];
int [,] secondarray = new int [n,m];
int [,] resultArray = new int[n,m];

FillArrayRandomNumbers(numbers);
Console.WriteLine(" Массив 1 ");
PrintArray(numbers);
Console.WriteLine();
FillArrayRandomNumbers(secondarray);
Console.WriteLine(" Массив 2 ");
PrintArray(secondarray);
Console.WriteLine();

if (numbers.GetLength(0) != secondarray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < secondarray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < numbers.GetLength(1); k++)
        {
            resultArray[i, j] += numbers[i, k] * secondarray[k, j];
        }
    }
}
Console.WriteLine(" Массив перемножен ");
PrintArray(resultArray);
Console.WriteLine();

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
               }
}


