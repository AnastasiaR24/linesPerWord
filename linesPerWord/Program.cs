using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linesPerWord
{
    internal class Program
    {//В ключ пусть записываются координаты (то что стоит после X)  а в значении первый символ строки(та цифра которая после K)
     // K0B3W300X|150 K0B3W300X|400 K0B3W300X|650 K0B3W300X|850 K2B1W600X|2500 K0B3W300X|2150 K0B3W300X|2400 K0B3W300X|2650 K0B3W300X|2850 K0B3W300X|4150 K0B3W300X|4400 K0B3W300X|4650 K0B3W300X|4850
        static void Main(string[] args)
        {
            string input = "K0B3W300X150K0B3W300X400K0B3W300X650K0B3W300X850K2B1W600X2500K0B3W300X2150K0B3W300X2400K0B3W300X2650K0B3W300X2850K0B3W300X4150K0B3W300X4400K0B3W300X4650K0B3W300X4850";
            string[] words = SplitText(input);
            Dictionary<string, string> resultDict = CreateDictionary(words);
            PrintDictionary(resultDict);
        }
        /// <summary>
        /// метод разбивает введенное предложение на отдельные слова и сохраняет их в массив words
        ///</summary>
        static string[] SplitText(string text)
        {
            // Убираем пустые строки
            string[] words = text.Split(new string[] { "X", "K" }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        /// <summary>
        /// метод выводит на экран каждое слово из массива words
        /// </summary>
        static Dictionary<string, string> CreateDictionary(string[] words)
        {
            Dictionary<string, string> coordinatesDictionary = new Dictionary<string, string>();
            for (int i = 1; i < words.Length - 1; i += 2)
            {
                string coordinate = words[i].Substring(0);
                string value = words[i].Substring(1);
                coordinatesDictionary[coordinate] = value;
            }
            return coordinatesDictionary;
        }

        static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"Ключ: {entry.Key}, Значение: {entry.Value}");
            }
        Console.ReadKey();
        }
    }
}
