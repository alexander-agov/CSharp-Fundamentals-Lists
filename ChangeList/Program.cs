using System.ComponentModel;

namespace ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] args = input.Split();
                switch (args[0])
                {
                    case "Delete":
                        int element = int.Parse(args[1]);
                        list.RemoveAll(e => e == element);
                        break;
                    case "Insert":
                        element = int.Parse((args[1]));
                        int index = int.Parse(args[2]);
                        list.Insert(index, element);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

