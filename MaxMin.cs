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
             Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = int.MinValue, max = 0, minlen = int.MaxValue, min = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    max = i;
                }
                
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length < minlen)
                {
                    minlen = str[i].Length;
                    min = i;
                }
            }
            Console.Write("Самое длинное слово: {0}, самое короткое слово: {1} ", str[max], str[min]);
            Console.ReadLine();

        }

    }

}