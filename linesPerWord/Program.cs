using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linesPerWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "K0B3W300X150K0B3W300X400K0B3W300X650K0B3W300X850K2B1W600X2500K0B3W300X2150K0B3W300X2400K0B3W300X2650K0B3W300X2850K0B3W300X4150K0B3W300X4400K0B3W300X4650K0B3W300X4850";
            string[] words = SplitText(input);
            PrintWords(words);
        }
        /// <summary>
        ///  метод разбивает введенное предложение на отдельные слова и сохраняет их в массив words
        ///</summary>
        static string[] SplitText(string text)
        {
            string[] words = text.Split('K');
            // Убираем пустые строки
            words = Array.FindAll(words, s => s != "");
            return words;
        }
        /// <summary>
        /// метод выводит на экран каждое слово из массива words
        /// </summary>
        static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine("K" + word);
            }
            Console.ReadKey();
        }
    }
}
