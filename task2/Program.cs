/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a, b, c;
         Console.WriteLine("Введите три числа : ");
         a = Convert.ToInt32(Console.ReadLine());
         b = Convert.ToInt32(Console.ReadLine());
         c = Convert.ToInt32(Console.ReadLine());
if ( a > b && a > c)
         {
             Console.WriteLine("{0} наибольшее число", a);
         }
if ( b > a  && b > c) 
         {
             Console.WriteLine("{0} наибольшее число", b);
         }
if ( c > a && c > b)
         {
             Console.WriteLine("{0} наибольшее число", c);
         }