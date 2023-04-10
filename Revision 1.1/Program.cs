namespace Revision_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter array length  : ");
            int input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();

            int couple;
            int NotCouple;
            for (int i = 0; i < array.Length; i++)
            {
                couple = 1;
                NotCouple = 1;
                if (array[i] % 2 == 0)
                {
                    couple = array[i] * array[array.Length - 1];
                    Console.WriteLine(couple);
                }
                if (array[i] % 2 != 0)
                {
                    NotCouple = array[i] * array[0];
                    Console.WriteLine(NotCouple);
                }
            }


        }
    }
}
