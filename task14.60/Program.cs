/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Сформируйте трехмерный массив");
Console.WriteLine("введите X");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Z");
int z = Convert.ToInt32(Console.ReadLine());
int [,,] numbers = new int [n,m,z];
int minNumber = 10;
int maxNumber = 99;

FillArrayRandomNumbers(numbers,minNumber, maxNumber);
PrintArray(numbers);

void FillArrayRandomNumbers(int[,,] array,  int minNumber = 0, int maxNumber = 9)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int h = 0; h < array.GetLength(2); h++)
                {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber + 1);

                    if (NumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool NumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


