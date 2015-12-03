using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPath
{
    class Program
    {

        private static long maxValue = long.MinValue;
        private static long currentPath = 0;
        static Dictionary<int, Node> nodes = new Dictionary<int, Node>();
        static Dictionary<int, bool> isUsed = new Dictionary<int, bool>();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                var nums = Console.ReadLine().Trim('(', ')')
                    .Split(new char[] { ' ', '<', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                //parent
                if (!nodes.ContainsKey(nums[0]))
                {
                    nodes.Add(nums[0], new Node(nums[0]));
                    if (!isUsed.ContainsKey(nums[0]))
                    {
                        isUsed.Add(nums[0], false);
                    }
                }

                var parent = nodes[nums[0]];

                //for child
                if (!nodes.ContainsKey(nums[1]))
                {
                    nodes.Add(nums[1], new Node(nums[1]));

                    if (!isUsed.ContainsKey(nums[1]))
                    {
                        isUsed.Add(nums[1], false);
                    }
                }

                var child = nodes[nums[1]];
                child.Children.Add(parent);
                parent.Children.Add(child);
            }


            foreach (var node in nodes)
            {
                if (node.Value.Children.Count == 1)
                {
                    TraverseDFS(node.Value);
                }
            }

            Console.WriteLine(maxValue);
        }

        static void TraverseDFS(Node node)
        {
           // if (isUsed[node.Value])
           // {
           //     if (currentPath > maxValue)
           //     {
           //         maxValue = currentPath;
           //     }
           //
           //     return;
           // }

            currentPath += node.Value;
            isUsed[node.Value] = true;

            foreach (var child in node.Children)
            {
                if (isUsed[child.Value])
                {
                    continue;
                }

                TraverseDFS(child);
            }


            isUsed[node.Value] = false;
            maxValue = Math.Max(maxValue, currentPath);
            currentPath -= node.Value;
        }
    }
    struct Node
    {
        public Node(int value)
            : this()
        {
            this.Value = value;
            this.Children = new List<Node>();
        }

        public int Value { get; set; }

        public List<Node> Children { get; set; }
    }


}
