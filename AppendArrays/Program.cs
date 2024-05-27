namespace AppendArrays
{
    internal class Program
    {
        static void Main()
        {
            string[] stringArrays = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            List<string> symbol = ExtractSymbols(stringArrays);
            Console.WriteLine(string.Join(" ", symbol));
        }

        private static List<string> ExtractSymbols(string[] stringArrays)
        {
            List<string> result = new List<string>();

            for (int i = stringArrays.Length - 1; i >= 0; i--)
            {
                string[] array = stringArrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                result.AddRange(array);
            }

            return result;
        }
    }
}
