using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SearchSymbol
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            Console.Write("Введите символ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == c)
                {
                   
                    k++;
                }
            }
            Console.WriteLine("Количество повторений заданного символа: " + k);
            Console.ReadKey();
        }

    }

}