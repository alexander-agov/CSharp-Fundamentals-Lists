namespace CardsGame
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            int minCount = Math.Min(firstPlayer.Count, secondPlayer.Count);
            while (minCount > 0)
            {
                if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.Add(firstPlayer[0]);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }
                else
                {
                    secondPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.RemoveAt(0);
                }
                minCount = Math.Min(firstPlayer.Count, secondPlayer.Count);
            }
            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
