/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];

//Создание списка чисел

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

//Сравнение по индексу

int Comparison(int[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(numbers[i] > 0 ) count += 1; 
  }
  return count;
}

//вывод решения

InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0: {Comparison(numbers)} ");