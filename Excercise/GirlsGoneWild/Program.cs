using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirlsGoneWild
{
    class Program
    {
        private static int[] teniskiMasiv;
        private static int numberOfGirls;
        private static char[] poliMasiv;
        private static int teniski;
        private static SortedSet<string> result = new SortedSet<string>();
        private static char[] poli;
        private static bool[] used;

        static void Main()
        {

            teniski = int.Parse(Console.ReadLine());
            poli = Console.ReadLine().ToCharArray();
            numberOfGirls = int.Parse(Console.ReadLine());

            teniskiMasiv = new int[numberOfGirls];
            poliMasiv = new char[numberOfGirls];
            used = new bool[poli.Length + 1];

            Comb(0, 0);

            Console.WriteLine(result.Count());
            //Console.WriteLine(string.Join("\n",result));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Comb(int index, int start)
        {
            if (index == numberOfGirls)
            {
                GenerateVariationsNoReps(0);
                return;
            }
            else
            {
                for (int i = start; i < teniski; i++)
                {
                    teniskiMasiv[index] = i;
                    Comb(index + 1, i + 1);
                }
            }
        }

        static void GenerateVariationsNoReps(int index)
        {
            if (index >= numberOfGirls)
            {
                var neshto="";
                for (int i = 0; i < numberOfGirls; i++)
                {
                    neshto += string.Format("{0}{1}-", teniskiMasiv[i], poliMasiv[i]);
                }

                 result.Add(neshto.Trim('-'));
                return;
            }
            else
            {
                for (int i = 0; i < poli.Length; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        poliMasiv[index] = poli[i];
                        GenerateVariationsNoReps(index + 1);
                        used[i] = false;
                    }
            }
        }
    }
}
