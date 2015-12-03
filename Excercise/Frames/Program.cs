using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frames
{
    class Program
    {
        private static int n;
        static SortedSet<string> result = new SortedSet<string>();
        static StringBuilder output = new StringBuilder();

        static void Main()
        {
            n = int.Parse(Console.ReadLine());

            var framesInput = new Frame[n];
            for (int i = 0; i < n; i++)
            {
                int[] sizes = Console.ReadLine()
                    .Split(' ')
                    .Select(x => int.Parse(x))
                    .ToArray();

                framesInput[i] = new Frame(sizes[0], sizes[1]);
            }

            Perm(framesInput, 0);

            Console.WriteLine(result.Count);
            foreach (var frame in result)
            {
                output.AppendLine(frame);
            }

            Console.WriteLine(output.ToString().Trim());

        }

        static void SwapFrameInside(ref Frame frame)
        {
            int oldFirst = frame.Width;
            frame.Width = frame.Height;
            frame.Height = oldFirst;
        }

        static void Perm(Frame[] frames, int k)
        {
            if (k >= frames.Length)
            {
                result.Add(string.Join(" | ", frames));
            }
            else
            {
                Perm(frames, k + 1); //27;50
                SwapFrameInside(ref frames[k]);
                Perm(frames, k + 1);
                SwapFrameInside(ref frames[k]);

                for (int i = k + 1; i < frames.Length; i++)
                {
                    Swap(ref frames[k], ref frames[i]);
                    Perm(frames, k + 1);

                    SwapFrameInside(ref frames[k]);
                    Perm(frames, k + 1);
                    SwapFrameInside(ref frames[k]);

                    Swap(ref frames[k], ref frames[i]);
                }
            }
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        struct Frame //po burzo no ne moje da ima mn pamet
        {

            public Frame(int w, int h) :
                this()
            {
                this.Height = h;
                this.Width = w;
            }
            public int Width { get; set; }
            public int Height { get; set; }

            public override string ToString()
            {
                return string.Format("({0}, {1})", this.Width, this.Height);
            }
        }
    }
}

//With ACTION
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Frames
//{
//    class Program
//    {
//        private static int n;
//        static void Main()
//        {
//            n = int.Parse(Console.ReadLine());

//            var frames = new Frame[n];
//            for (int i = 0; i < n; i++)
//            {
//                int[] sizes = Console.ReadLine()
//                    .Split(' ')
//                    .Select(x => int.Parse(x))
//                    .ToArray();

//                frames[i] = new Frame(sizes[0], sizes[1]);
//            }

//            Perm(frames, 0, (x) => Console.WriteLine(x));
//        }

//        static void Perm<T>(T[] arr, int k, Action<T[]> action)
//        {
//            if (k >= arr.Length)
//            {
//                action(arr);
//            }
//            else
//            {
//                Perm(arr, k + 1, action);
//                for (int i = k + 1; i < arr.Length; i++)
//                {
//                    Swap(ref arr[k], ref arr[i]);
//                    Perm(arr, k + 1, action);
//                    Swap(ref arr[k], ref arr[i]);
//                }
//            }
//        }

//        static void Swap<T>(ref T first, ref T second)
//        {
//            T oldFirst = first;
//            first = second;
//            second = oldFirst;
//        }

//        struct Frame //po burzo no ne moje da ima mn pamet
//        {

//            public Frame(int w, int h)
//                : this()
//            {
//                //this.Height = h;
//                //this.Width = w;
//            }
//            public int Width { get; set; }
//            public int Height { get; set; }
//        }
//    }
//}
