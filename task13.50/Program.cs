/*Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/
Console.WriteLine("введите кол-во строк матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите порядковый номер элемента, который хотите найти: ");
int findnumber = Convert.ToInt32(Console.ReadLine());
if (findnumber > n*m - 1){
Console.WriteLine("-> такого элемента нет");
}
else
{
    int[,] numbers = new int[n, m];
    int i1 = 0;
    int j1 = 0;
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    i1 = findnumber / m;
    if (i1 != n)
    {
        j1 = findnumber % m;
        Console.WriteLine($"Элемент который вы ищите: {numbers[i1, j1]}");
    }
    else
    {
        Console.WriteLine("-> такого элемента нет");
    }
}


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
