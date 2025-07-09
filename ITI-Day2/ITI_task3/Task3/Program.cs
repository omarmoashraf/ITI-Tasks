namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Max = -1;
            int[] Degrees = new int[n];
            for (int i = 0; i < Degrees.Length; i++)
            {
                int grade = int.Parse(Console.ReadLine());
                Degrees[i] = grade;
                if (grade > Max)
                {
                    Max = grade;
                }
            }
            Console.WriteLine($"The maximum grade is {Max}");

        }
    }
}
