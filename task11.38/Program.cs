/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int lenArray = ReadInt("Введите количество чисел массива: ");
int min = ReadInt("Введите минимальное число - границу массива: ");
int max = ReadInt("Введите максимальное число - границу массива: ");
int[] randomArray = new int[lenArray];


FillArray(randomArray);
Console.WriteLine();
int maxarray = randomArray[0];
int minarray = randomArray[0];

for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] > maxarray)
    {
        maxarray = randomArray[i];
    }
    if (randomArray[i] < minarray)
    {
        minarray = randomArray[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxarray - minarray}");

// заполняем массив числами в диапазоне введеным пользователем 

void FillArray(int [] array) 
{
    for (int i = 0; i < randomArray.Length; i++)
    {
    randomArray[i] = new Random().Next(min,max);
    Console.Write(randomArray[i] + " ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

