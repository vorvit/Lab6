using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6-1. Поиск самого длинного слова в предложении
            Console.WriteLine("Введите предложение без знаков препинания");
            string startStr = Console.ReadLine();
            string[] sArr = startStr.Split();
            string resultStr = "";
            foreach (string s in sArr)
            {
                resultStr = (s.Length > resultStr.Length) ? s : resultStr;
            }
            Console.WriteLine("{0} - первое самое длинное слово в предложении, состоит из {1} букв", resultStr, resultStr.Length);
            Console.ReadKey();
        }
    }
}
