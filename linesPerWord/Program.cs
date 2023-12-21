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
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();
            string[] words = SplitText(input);
            PrintWords(words);
        }
        /// <summary>
        ///  метод разбивает введенное предложение на отдельные слова и сохраняет их в массив words
        ///</summary>
        static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }
        /// <summary>
        /// метод выводит на экран каждое слово из массива words
        /// </summary>
        static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
        
    }
}
