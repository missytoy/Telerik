using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {

        static Dictionary<string, int> dumichki = new Dictionary<string, int>();

        static void Main()
        {
            HashSet<string> dumichkiHvaniGiFromText = new HashSet<string>();
            List<string> words = new List<string>();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string line = Console.ReadLine().ToLower();
                var allWords = line.Split(new char[] { ' ', '-', ',', '!', '?' });

                foreach (var word in allWords)
                {
                    dumichkiHvaniGiFromText.Add(word);
                }
            }

            int somethingLikeWordCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < somethingLikeWordCount; i++)
            {
                string line = Console.ReadLine();
                AddNameToDictionary(line);
                words.Add(line);

            }

           foreach (var word in words)
             {
                 string someWordToCheck = word.ToLower();
                 foreach (var unique in dumichkiHvaniGiFromText)
                 {
                     bool isContained = true;
                     for (int i = 0; i < someWordToCheck.Length; i++)
                     {
                         if (unique.IndexOf(someWordToCheck[i]) == -1)
                         {
                             isContained = false;
                             break;
                         }
                     }
                     if (isContained)
                     {
                         AddNameToDictionary(word);
                     }
                 }
             }



           foreach (var item in dumichki)
           {
               Console.WriteLine("{0} -> {1}", item.Key, item.Value);
           }

        }
 
        static private void AddNameToDictionary(string name)
        {
            int count;
            if (dumichki.TryGetValue(name, out count))
            {
                count++;
            }
            else
            {
                count = 0;
            }

            dumichki[name] = count;
        }
    }
}


//HashSet<string> dumichkiHvaniGi = new HashSet<string>();
//            List<string> words = new List<string>();
//            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
//            int t = int.Parse(Console.ReadLine());
//            for (int i = 0; i < t; i++)
//            {
//                string line = Console.ReadLine().ToLower();
//                string word = string.Empty;
//                bool inWord = false;
//                for (int j = 0; j < line.Length; j++)
//                {
//                    if (char.IsLetter(line[j]))
//                    {
//                        inWord = true;
//                        word += line[j];
//                    }
//                    else if(!char.IsLetter(line[j]) && inWord)
//                    {
//                        inWord = false;
//                        dumichkiHvaniGi.Add(word);
//                        word = string.Empty;
//                    }
//                }
//            }
//            int w = int.Parse(Console.ReadLine());
//            for (int i = 0; i < w; i++)
//            {
//                var inputWord = Console.ReadLine();
//                wordCounts.Add(inputWord, 0);
//                words.Add(inputWord);
//            }
//            foreach (var word in words)
//            {
//                string someWordToCheck = word.ToLower();
//                foreach (var unique in dumichkiHvaniGi)
//                {
//                    bool isContained = true;
//                    for (int i = 0; i < someWordToCheck.Length; i++)
//                    {
//                        if (unique.IndexOf(someWordToCheck[i]) == -1)
//                        {
//                            isContained = false;
//                            break;
//                        }
//                    }
//                    if (isContained)
//                    {
//                        wordCounts[word]++;
//                    }
//                }
//            }
//            foreach (var item in wordCounts)
//            {
//                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
//            }