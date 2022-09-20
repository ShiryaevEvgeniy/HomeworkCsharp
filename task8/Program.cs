/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
//строка используется только для  отклонения 3 значного числа
*/

Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());;
int amount = number.ToString().Length;
int d = GetSecondDigit(number);

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы указали не трехзначное число");
}
else
{
    Console.WriteLine(d);
    Console.ReadKey();
}

static int GetSecondDigit(int k)
{
    while (k >= 100) k /= 10;
    int d = k % 10;
    return d;
}
