/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int lenArray = ReadInt("Введите количество чисел массива: ");
int min = ReadInt("Введите минимальное число - границу массива: ");
int max = ReadInt("Введите максимальное число - границу массива: ");
int[] randomArray = new int[lenArray];


FillArray(randomArray);
Console.WriteLine();
int result = 0;

for (int i = 0; i < randomArray.Length; i++)
{
    if (i % 2 != 0)
    {
        result += randomArray[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

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

