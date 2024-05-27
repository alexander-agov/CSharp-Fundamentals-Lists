using System.Net;
using System.Security.Principal;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main()
        {

            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            newList.AddRange(list);
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                if (command == "end")
                {
                    break;
                }
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


                if (command == "Contains")
                {
                    if (list.Contains(int.Parse(tokens[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    var even = list.Where(i => i % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", even));
                }
                else if (command == "PrintOdd")
                {
                    var odd = list.Where(i => i % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ", odd));
                }
                else if (command == "GetSum")
                {
                    var sum = list.Sum();
                    Console.WriteLine(sum);
                }
                else if (command == "Filter")
                {
                    if ((tokens[1] == ">"))
                    {
                        var biggerNumbers = list.Where(n => n > int.Parse(tokens[2]));
                        foreach (var n in biggerNumbers)
                        {
                            Console.Write(n + " ");
                        }
                        Console.WriteLine();
                    }
                    if ((tokens[1] == "<"))
                    {
                        var smallestNumbers = list.Where(n => n < int.Parse(tokens[2]));
                        foreach (var n in smallestNumbers)
                        {
                            Console.Write(n + " ");
                        }
                        Console.WriteLine();
                    }
                    if ((tokens[1] == ">="))
                    {
                        var greaterNumbers = list.Where(n => n >= int.Parse(tokens[2]));
                        foreach (var n in greaterNumbers)
                        {
                            Console.Write(n + " ");
                        }
                        Console.WriteLine();
                    }
                    if ((tokens[1] == "<="))
                    {
                        var minorNumbers = list.Where(n => n <= int.Parse(tokens[2]));
                        foreach (var n in minorNumbers)
                        {
                            Console.Write(n + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            if (list.Count != newList.Count || list.Sum() != newList.Sum())
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
