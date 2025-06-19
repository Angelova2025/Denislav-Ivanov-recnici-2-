namespace _recnici__test_zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Dictionary<string, int> count = new Dictionary<string, int>();
            string name;

            while ((name = Console.ReadLine()) != "stop")
            {
                if (count.ContainsKey(name))
                {
                    count[name]++;
                }
                else
                {
                    count.Add(name, 1);
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
