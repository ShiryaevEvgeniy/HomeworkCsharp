/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[,]coeff = new double[2, 2];
double[] cross = new double[2];

//Ввод коэфициентов

void InputCoeff()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите углвые коэффициенты для уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите угловой коэффициент k: ");
      else Console.Write($"Введите угловой коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

// Решение задачи 

double[] Findingcross(double[,] coeff)

{
  cross[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  cross[1] = cross[0] * coeff[0,0] + coeff[0,1];
  return cross;
}

//Вывод результата

void Output(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\n Прямые совпадают, у нас бесконечно много решений");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\n Прямые параллельны, решения нет");
  }
  else 
  {
    Findingcross(coeff);
    Console.Write($"\n Точка пересечения прямых: ({cross[0]}, {cross[1]})");
  }
}
InputCoeff();
Output(coeff);