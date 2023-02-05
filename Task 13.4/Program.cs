using System;
using System.Diagnostics.CodeAnalysis;

namespace Task_13._4
{
    internal class Program
    { //Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0
      //(больше 0 не встречается в последовательности). Определить модуль суммы каких чисел больше,
      //положительных или отрицательных.
        static void Main(string[] args)
        {
            int input;
            int sum1 = 0;
            int sum2 = 0;
            int i = 0;

            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 0)
                {
                    sum1 += input;
                }
                else
                {
                    sum2 += input;
                }
               
            }
            while (input!=0);
            if (sum1 > sum2 *-1 )
            if (sum1 > sum2 *-1 )
            {
                Console.WriteLine(sum1);

            }
            else
            {
                Console.WriteLine(sum2);
            }
        }
    }
}
