using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MinMaxLen
    {
        public static void Main(string[] args)
        {
            /*1*/
            Console.Write("Введите строку: ");          //вывод сообщения                                                    
                                                        /*2*/
            string input = Console.ReadLine();          //ввод с клавиатуры                                                  
                                                        /*3*/
            string[] str;
            int max, min;
            Proverka(input, out str, out max, out min);//конец цикла

            /*13*/
            Console.Write("Самое длинное слово: {0}, самое короткое слово: {1} ", str[max], str[min]);      //вывод результата
            Console.ReadLine();
        }

        public static void Proverka(string input, out string[] str, out int max, out int min)
        {
            str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            /*4*/
            int maxlen = int.MinValue, minlen = int.MaxValue;     //ввод параметров
            max = 0;
            min = 0;

            /*5*/
            for (int i = 0; i < str.Length; i++)         //начало цикла, условие i < str.Length
            {

                /*6*/
                MaxLen(str, ref maxlen, ref max, i);     //условие str[i].Length > maxlen

                /*7*/
            }                                           //конец цикла

            /*8*/
            for (int i = 0; i < str.Length; i++)   //начало цикла, условие i < str.Length
            {

                /*9*/
                if (str[i].Length < minlen)        //условие str[i].Length < minlen
                {

                    /*10*/
                    minlen = str[i].Length;             //условие minlen = str[i].Length

                    /*11*/
                    min = i;                            //условие min = i
                }

                /*12*/
            }
        }

        public static void MaxLen(string[] str, ref int maxlen, ref int max, int i)     
        {
            
       if (str[i].Length > maxlen)        
            {
               
          maxlen = str[i].Length;     
                max = i;
                
            }      
        }          
    }

    
     

}
