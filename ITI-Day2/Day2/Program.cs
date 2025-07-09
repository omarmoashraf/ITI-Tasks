namespace Day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (c >= '0' && c <= '9')
                {
                    Console.WriteLine("Invalid Input ");
                    break;
                }

            }
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            age = (age > 0) ? age : 0;


            Console.WriteLine("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            ID = (ID > 0) ? ID : 0;
            

            Console.WriteLine("Enter salary: ");
            int salary = int.Parse(Console.ReadLine());
            salary = (salary > 0) ? salary : 0;



        }
    }
}
