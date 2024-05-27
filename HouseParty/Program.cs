using System.Xml.Linq;

namespace HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] args = Console.ReadLine().Split(" ");
                if (args[2] == "going!")
                {
                    string name = args[0];
                    int index = guestList.IndexOf(name);
                    if (index != -1)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (args[2] == "not")
                {
                    string name = args[0];
                    int index = guestList.IndexOf(name);
                    if (index != -1)
                    {
                        guestList.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
