using System.ComponentModel;

namespace MergingLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstList = ReadNumbers();
            List<int> secondList = ReadNumbers();

            List<int> result = new List<int>();

            int greatererCount = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < greatererCount; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }
            PrintResult(result);
        }
        static List<int> ReadNumbers()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
        static void PrintResult(List<int> numbers, string separator = " ")
        {
            Console.WriteLine(string.Join(separator, numbers));
        }
    }
}
