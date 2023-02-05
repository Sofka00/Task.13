using System;

namespace Task_13._3
{//3) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0
 //(больше 0 не встречается в последовательности). Найти количество чисел в последовательности,
 //которые делятся на 3, 7 или 11.
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int count = 0;

            do
            {
                input = Convert.ToInt32(Console.ReadLine());

                {
                    if ((input % 3 == 0 || input % 7 == 0 || input % 11 == 0) && input != 0)
                    {

                        count++;

                    }

                }

            }
            while (input != 0);


            Console.WriteLine(count);
        }
    }
}
