namespace Basic_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            int year = dateTime.Year;
            Console.WriteLine("Please provide a name:");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("How old are you?");
            int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine($"{name}, you were born in {year - age}");

            //part 2

        }
    }
}