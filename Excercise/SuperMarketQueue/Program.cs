using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace SuperMarketQueue
{
    class Program
    {
        static MyQueue repository = new MyQueue();
        static StringBuilder result = new StringBuilder();

        static void Main()
        {
            string command = null;
            while (command != "End")
            {
                command = Console.ReadLine();
                ProcessCommand(command);
            }

            Console.WriteLine(result);
        }

        static void ProcessCommand(string command)
        {
            string[] commandParts = command.Split(' ');
            string commandName = commandParts[0];
            switch (commandName)
            {
                case "Append":
                    string name = commandParts[1];
                    repository.Append(name);
                    result.AppendLine("OK");
                    break;
                case "Insert":
                    int position = int.Parse(commandParts[1]);
                    name = commandParts[2];
                    result.AppendLine(repository.Insert(position, name));

                    break;
                case "Find":
                    name = commandParts[1];
                    result.AppendLine(string.Format("{0}", repository.Find(name)));
                    break;
                case "Serve":
                    int count = int.Parse(commandParts[1]);
                    result.AppendLine(string.Join(" ", repository.Serve(count)));
                    break;
                case "End":
                    break;
                default:
                    throw new InvalidOperationException("Invalid command: " + command);
            }
        }

        public class MyQueue
        {
            BigList<string> repository = new BigList<string>();
            Bag<string> names = new Bag<string>();

            public void Append(string name)
            {
                this.repository.Add(name);
                this.names.Add(name);
            }

            public string Insert(int position, string name)
            {
                if ((names.Count < 1 && position != 0) || position > names.Count)
                {
                    return "Error";
                }
                this.repository.Insert(position, name);
                this.names.Add(name);

                return "OK";
            }

            public int Find(string name)
            {
                int occurences = this.names.NumberOfCopies(name);
                return occurences;
            }

            public IList<string> Serve(int count)
            {
                var servedNames = new List<string>();
                if (this.repository.Count < count)
                {
                    servedNames.Add("Error");
                    return servedNames;
                }

                servedNames = this.repository.Range(0, count).ToList();
                this.repository.RemoveRange(0, count);
                this.names.RemoveMany(servedNames);
                return servedNames;
            }
        }

    }
}
