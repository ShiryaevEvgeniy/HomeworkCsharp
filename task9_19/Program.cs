/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число " + num + " является палиндромом? -> " +
(isPalindrome(num) == 1 ? "да" : "нет"));     

int reverseDigits(int num)
    {
        int rev_num = 0;
        while (num > 0) {
            rev_num = rev_num * 10 + num % 10;
            num = num / 10;
        }
        return rev_num;
    }   
// Проверка на палиндром
int isPalindrome(int n)
    {
               int rev_n = reverseDigits(n);
               if (rev_n == n)
            return 1;
        else
            return 0;
    }
