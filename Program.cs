namespace Programming4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your height in cm: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your full name is {firstName} {lastName}.");

            Console.WriteLine($"\tYour height is {height} cm and you are {age} years old.");
        }
    }
}
