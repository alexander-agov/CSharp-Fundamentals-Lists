﻿
namespace BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            list = Explode(list, bomb);
            Console.WriteLine(list.Sum());

        }


        static List<int> Explode(List<int> list, List<int> bomb)
        {
            int number = bomb[0];
            int power = bomb[1];

            while (list.Contains(number))
            {
                int index = list.IndexOf(number);
                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(list.Count - 1, index + power); //Math.Clamp(1, 10, 212)
                int range = rightIndex - leftIndex + 1;
                list.RemoveRange(leftIndex, range);

            }
            return list;
        }
    }
}
