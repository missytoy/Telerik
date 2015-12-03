using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath_C_
{
    class Program
    {
        private static char[] letters = new char[] { 'R', 'L', 'S' };
        private static char[] theCombinations;
        private static bool[] isFree;
        private static SortedSet<string> result = new SortedSet<string>();
        private static int counter = 0;
        private static string input = "";
        private static char[] copyInput;

        static void Main()
        {
            input = Console.ReadLine();
            copyInput = input.ToCharArray();
            isFree = new bool[input.Length];
            counter = 0;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    counter += 1;
                    isFree[i] = true;
                    if (counter == 0)
                    {
                        index = i;
                    }
                }
            }

            theCombinations = new char[counter];
            
            Console.WriteLine(Math.Pow(3, counter));
            GenerateVariations(0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void GenerateVariations(int index)
        {
            if (index >= counter)
            {
                var j = 0;
                //result.AppendLine(string.Join(" ", theCombinations)); // R R R R R 

                for (int i = 0; i < copyInput.Length; i++)
                {
                    if (isFree[i])
                    {
                        copyInput[i] = theCombinations[j];
                        j++;
                    }
                }
                j = 0;

                result.Add(string.Join("", copyInput));
            }
            else
            {
                for (int i = 0; i < letters.Count() ; i++)
                {
                    theCombinations[index] = letters[i];
                    GenerateVariations(index + 1);
                }
            }
        }
    }
}
