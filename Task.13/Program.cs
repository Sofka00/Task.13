using System;

namespace Task._13
{
    internal class Program
    { // 1. Пользователь вводит пароль до тех пор, пока введенное значение не будет равно "Pass123!"
        static void Main(string[] args)
        {
            string pass;
            do
            {
                pass = Convert.ToString(Console.ReadLine()); ;
            }
            while (pass != "Pass123");
        }
    }
}
