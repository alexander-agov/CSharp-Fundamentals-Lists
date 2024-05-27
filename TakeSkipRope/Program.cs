using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace TakeSkipRope
{
    internal class Program
    {
        static void Main()
        {
            string args = Console.ReadLine();
            List<int> numberList = new List<int>();
            List<string> stringList = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            string newList = "";
            foreach (char c in args)
            {
                if (char.IsDigit(c))
                {
                    numberList.Add(int.Parse(c.ToString()));
                }
                else
                {
                    stringList.Add(c.ToString());
                }
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i]);
                }
                else
                {
                    skipList.Add(numberList[i]);
                }
            }
            int index = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(stringList);
                stringList.RemoveRange(0, index);
                temp = stringList.Take(takeList[i]).ToList();
                foreach (string s in temp)
                {
                    newList += s;
                }
                index = takeList[i] + skipList[i];
            }
            Console.WriteLine(newList);
        }
    }
}
/*
 for (int i = 0; i < takeList.Count; i++)
    {
        List<string> temp = new List<string>(stringList);
        temp = temp.Skip(index).Take(takeList[i]).ToList();
        foreach (string s in temp)
        {
            newList += s;
        }
        index = takeList[i] + skipList[i];
    }
*/


