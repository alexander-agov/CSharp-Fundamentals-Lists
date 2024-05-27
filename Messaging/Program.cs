using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    internal class Program
    {
        static void Main()
        {
            string[] sequence = Console.ReadLine().Split();
            string text = Console.ReadLine().Trim();
            string message = "";

            while (sequence.Length > 0)
            {
                int sum = 0;
                foreach (char digit in sequence[0])
                {
                    sum += int.Parse(digit.ToString());
                }
                int index = sum % text.Length;
                message += text[index];
                text = text.Remove(index, 1);
                sequence = sequence.Skip(1).ToArray();
            }

            Console.WriteLine(message);
        }
    }
}
