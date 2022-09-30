/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int lenArray = ReadInt("Введите количество чисел массива: ");
int[] randomArray = new int[lenArray];

FillArray(randomArray);
Console.WriteLine();
int result = 0;

for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] % 2 == 0)
    {
        result++;
    }
}
Console.WriteLine($"В массиве {result} четных чисел");

// заполняем массив числами от 100 до 999

void FillArray(int [] array) 
{
    for (int i = 0; i < randomArray.Length; i++)
    {
    randomArray[i] = new Random().Next(99,999);
    Console.Write(randomArray[i] + " ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

