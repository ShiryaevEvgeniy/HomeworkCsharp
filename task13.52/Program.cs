/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("введите кол-во строк матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [n,m];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.Write("Среднеарифметическое в каждом столбце: ");
Srednearifm(numbers);

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

void Srednearifm(int[,] array)
{
        for (int j = 0; j < array.GetLength(1); j++)
    {
        decimal sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    decimal d = Math.Round(sum / array.GetLength(0),2);
    Console.Write($" {d} ;");
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
