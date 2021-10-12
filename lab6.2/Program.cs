using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //вводим строку
            string sr = ""; //
            bool r = true;

            for (int i = 0; i < s.Length; i++) //избавляемся от пробелов
            {
                if (s[i] != ' ')
                {
                    sr += s[i];
                }
            }
            sr = sr.ToLower(); //и от заглавных букв


            for (int i = 0, j = sr.Length-1; i < j; i++, j--) //итоговую строку проверяем на палиндром
            {
                if (sr[i] != sr[j])
                {
                    r = false;
                }

            }

            if (r)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не, не палиндром");
            }



            Console.ReadKey();
        }
    }
}
