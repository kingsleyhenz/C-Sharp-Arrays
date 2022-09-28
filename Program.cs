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

             Console.WriteLine("Enter Number Of Students");
             int studnum = Convert.ToInt32(Console.ReadLine());

             int[] students = new int[studnum];
             int count = 0;

             Console.WriteLine("Enter Students Grade");
             for (int i = 0; i < students.Length; i++)
             {
                 students[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("These are the grades");
             for (int i = 0; i < students.Length; i++)
             {
                 count++;
                 Console.WriteLine(count + ":" + " " + students[i]);
             }
            */

            /*MULTI-DIMENSIONAL ARRAYS*/
            String[] Toyota = { "corolla", "camry", "venz" };
            String[] Honda = { "Civic", "Pilot", "Accord" };
            String[] Benz = { "Maybach", "G-wagon", "GLR" };

            String[,] cars = { {"corolla", "camry", "venza"},
                               {"Civic", "Pilot", "Accord"},
                               {"Maybach", "G-wagon", "GLR" }
            };

            cars[0, 2] = "Highlander";
            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}