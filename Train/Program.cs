namespace Train
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int findElement = -1;
            int index = -1;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split();
                if (input[0] == "Add" && int.Parse(input[1]) <= maxCapacity)
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    findElement = wagons.Find(n => n + int.Parse(input[0]) <= maxCapacity);
                    if (findElement + int.Parse(input[0]) <= maxCapacity)
                    {
                        index = wagons.IndexOf(findElement);
                        wagons[index] += int.Parse(input[0]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}

