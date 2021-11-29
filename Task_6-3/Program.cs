using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6-3. Удаление текста в фигурных скобках
            Console.WriteLine("Введите строку текста:");
            string str = Console.ReadLine();
            bool f = false;
            int count = 0;
            string strRes = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{')
                {
                    f = true;
                    count++;
                }
                if (str[i] == '}')
                {
                    count--;
                    f = (count == 0) ? false : true;
                    continue;
                }
                if (f == false && count == 0)
                {
                    strRes += str[i];
                }
            }
            Console.WriteLine("Полученная строка:");
            Console.WriteLine(strRes);
            Console.ReadKey();
        }
    }
}
