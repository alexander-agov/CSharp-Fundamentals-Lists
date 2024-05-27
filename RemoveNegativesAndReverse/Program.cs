using System.Linq;

namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
            }
            if (positiveNumbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            positiveNumbers.Reverse();
            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
    }
}


