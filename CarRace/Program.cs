using System;

namespace CarRace
{
    internal class Program
    {
        static void Main()
        {
            List<int> race = Console.ReadLine().Split().Select(int.Parse).ToList();
            int half = race.Count / 2;
            List<int> leftSide = race.GetRange(0, half);
            List<int> rightSide = race.GetRange(half + 1, half);
            double leftSum = 0;
            double rightSum = 0;
            if (!leftSide.Contains(0))
            {
                leftSum += leftSide.Sum();
            }
            else
            {
                int findIndex = leftSide.FindIndex(x => x == 0);
                for (int j = 0; j < findIndex; j++)
                {
                    leftSum += leftSide[j] * 0.8;
                }
                for (int k = findIndex + 1; k < leftSide.Count(); k++)
                {
                    leftSum += leftSide[k];
                }
            }

            if (!rightSide.Contains(0))
            {
                rightSum += rightSide.Sum();
            }
            else
            {
                int findIndex = rightSide.FindIndex(x => x == 0);
                for (int j = rightSide.Count - 1; j > 0; j--)
                {
                    rightSum += rightSide[j] * 0.8;
                }
                for (int k = findIndex - 1; k >= 0; k--)
                {
                    rightSum += rightSide[k];
                }
            }
            if (leftSum > rightSum)
            {
                Console.WriteLine($"The winner is right with total time: {FormatResult(rightSum)}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {FormatResult(leftSum)}");
            }
        }
        static string FormatResult(double result)
        {
            if (result % 1 == 0)
            {
                return ((int)result).ToString();
            }
            else
            {
                return result.ToString("f1");
            }
        }
    }
}
