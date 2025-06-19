namespace _recnici__zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string, List<string>> Books = new Dictionary<string, List<string>>();
            List<string> Order = new List<string>();
            string line;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] parts = line.Split(new string[] {"-->"} , StringSplitOptions.None);
                string Name = parts[0];
                string title = parts[1];

                if (!Books.ContainsKey(Name))
                {
                    Books.Add(Name, new List<string>());
                    Order.Add(Name);
                }
                Books[Name].Add(title);
            }
            foreach (string Name in Order)
            {
                Console.WriteLine($"{Name}: {string.Join(",", Books[Name])}");
            }
        }
    }
}
