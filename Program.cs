namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ARRAYS*/
           /* string[] names = { "Adebayo", "Mike", "Sophia", "David", "Faithful", "Obinna" };

            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
           */
            int[] age = new int[5];
            age[0] = 16;
            age[1] = 23;
            age[2] = 60;
            age[3] = 2;
            age[4] = 19;

            Console.WriteLine("Enter your age:");
            for (int i = 0; i < age.Length; i++)
            {

                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(age[i]);
            }

        }
    }
}