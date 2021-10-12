using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //вводим строку
            int k = 0;//инициализируем счетчик
            string sr = "";//и итоговую строку


            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '{')
                    k++;

                if (s[i] == '}')
                    k--;

                if (k == 0 && s[i] != '}')
                {
                    sr += s[i];
                }
            }



            Console.WriteLine(sr);
            Console.ReadKey();
        }
    }
}
