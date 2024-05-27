namespace AnonymousThreat
{
    internal class Program
    {
        static void Main()
        {
            List<string> data = Console.ReadLine().Split().ToList();
            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] com = command.Split();
                if (com[0] == "merge")
                {
                    int startIndex = int.Parse(com[1]);
                    int endIndex = int.Parse(com[2]);
                    data = Merge(data, startIndex, endIndex);
                }
                if (com[0] == "divide")
                {
                    int index = int.Parse(com[1]);
                    int partitions = int.Parse(com[2]);
                    data = Divide(data, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }

        static List<string> Merge(List<string> list, int startIndex, int endIndex)
        {
            startIndex = Clamp(startIndex, 0, list.Count); //-1
            endIndex = Clamp(endIndex, 0, list.Count - 1);
            string merged = string.Join("", list.GetRange(startIndex, endIndex - startIndex + 1));
            list.RemoveRange(startIndex, endIndex - startIndex + 1);
            list.Insert(startIndex, merged);
            return list;
        }

        private static List<string> Divide(List<string> list, int index, int partitions)
        {
            string element = list[index];
            if (partitions <= 0)
            {
                return list;
            }
            list.RemoveRange(index, 1);
            int subLength = element.Length / partitions;
            int remainingChars = element.Length % partitions;
            List<string> newElements = new List<string>();
            int elementIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                string newString = "";
                for (int j = 0; j < subLength; j++)
                {
                    newString += element[elementIndex];
                    elementIndex++;
                }
                newElements.Add(newString);
            }
            if (remainingChars > 0 && newElements.Count > 0)
            {
                for (int i = elementIndex; i < element.Length; i++)
                {
                    newElements[newElements.Count - 1] += element[i];
                }
            }
            list.InsertRange(index, newElements);
            return list;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
            }
            else if (value > max)
            {
                value = max;
            }
            return value;
        }
    }
}
