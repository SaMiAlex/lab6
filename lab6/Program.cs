using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //вводим строку           
            string[] sArray = s.Split();//создаем массив
            string s1, smax;
            int d = 0;//длина слова
             smax = "";

            for (int i = 0; i < sArray.Length; i++)
            {
                s1 = "";
                    s1 += sArray[i];

                if (s1.Length > d)
                {
                    d = s1.Length;
                    smax = s1;
                }

                
            }


            Console.WriteLine("Самое длинное слово - {0} длиной в {1} символов", smax, d);
            Console.ReadKey();
        }
    }
}
