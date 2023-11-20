using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1) Дан массив чисел {2,4,1,3,90,654,900,1024,96,51}
С помощью linq вытащить все четные и нечетные числа
2) Дан текст:
"Привет! Это голосовой помощник Олег! Оставьте свое сообщение!"
Используя LINQ, найти все слова, в которых есть буква либо о, либо т. Так же, найти слова, которые оканчиваются на е, либо к
 */
namespace DZCH12
{

    internal class Program
    {
        static void Q1()
        {


            int[] num = { 2, 4, 1, 3, 90, 654, 900, 1024, 96, 51 };

            IEnumerable<IGrouping<int, int>> numLQ = from i in num
                                                     group i by i % 2;


            foreach(IGrouping<int, int> group in numLQ)
            {
                Console.WriteLine("Key: " + group.Key);
                foreach(int item in group)
                {
                    Console.WriteLine("Item:"+item);
                }
            }
        }
        static void Q2()
        {

            string text = "Привет! Это голосовой помощник Олег! Оставьте свое сообщение!" ;
            string[] wordsX = text.Split(new char[] { ' ', '!', '?', '.', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);



            var wordsWithOorT = from word in wordsX
                                where word.Contains('о') || word.Contains('т')
                                select word;

            Console.WriteLine("Слова, содержащие букву 'о' или 'т':");
            foreach (var word in wordsWithOorT)
            {
                Console.WriteLine(word);
            }

            var wordsEndsWithEorK = from word in wordsX
                                    where word.EndsWith("е") || word.EndsWith("к")
                                    select word;

            Console.WriteLine("\nСлова, оканчивающиеся на 'е' или 'к':");
            foreach (var word in wordsEndsWithEorK)
            {
                Console.WriteLine(word);
            }



        }
        static void Main(string[] args)
        {
           // Q1();
            // Q2();
        }
    }
}
