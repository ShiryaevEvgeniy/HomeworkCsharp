/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введи цифру, обозначающую день недели: ");
int weeknumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int weeknumber) {
  if (weeknumber == 6 || weeknumber == 7) {
  Console.WriteLine("Это выходной день -> да");
  }
  else if (weeknumber < 1 || weeknumber > 7) {
    Console.WriteLine("нет такого дня недели");
  }
  else Console.WriteLine("это день не выходной -> нет");
}
CheckingTheDayOfTheWeek(weeknumber);