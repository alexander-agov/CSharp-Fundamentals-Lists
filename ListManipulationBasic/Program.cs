namespace ListManipulationBasic
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                if (command == "Add")
                {
                    list.Add(int.Parse(tokens[1]));
                }
                else if (command == "Remove")
                {
                    list.Remove(int.Parse(tokens[1]));
                }
                else if (command == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(tokens[1]));
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int number = int.Parse(tokens[1]);
                    list.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

