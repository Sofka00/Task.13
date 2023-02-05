using System;

namespace Task_13._2
{ //2) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0
  //(больше 0 не встречается в последовательности). Найти самое большое число последовательности.
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int max = 0;
            do
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                }

            }
            while (input != 0);

            Console.WriteLine(max);
        }
    }
}
