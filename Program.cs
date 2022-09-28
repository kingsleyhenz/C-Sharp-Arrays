namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ARRAYS*/
            string[] names = { "Adebayo", "Mike", "Sophia", "David", "Faithful", "Obinna" };

            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}