using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6-2. Проверка на палиндром
            Console.WriteLine("Введите предложение без знаков препинания");
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            str = str.ToLower();
            bool f = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    f = false;
                }
            }
            if (f == false)
            {
                Console.WriteLine("Введенное предложение - не является палиндромом");
            }
            else
            {
                Console.WriteLine("Введенное предложение - палиндром");
            }
            Console.ReadKey();
        }
    }
}
