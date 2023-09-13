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
            Console.WriteLine("Provide the first number to be added (no decimals)");
            int.TryParse(Console.ReadLine(), out int numOne);
            Console.WriteLine("Provide the second number");
            int.TryParse(Console.ReadLine(), out int numTwo);
            Console.WriteLine("Provide num three");
            int.TryParse(Console.ReadLine(), out int numThree);
            Console.WriteLine($"You're total is {numOne + numThree + numTwo}");

            //part 3
            Console.WriteLine("Provide a distance in km");
            double.TryParse(Console.ReadLine(), out double dis1);
            Console.WriteLine("Provide a second distance");
            double.TryParse(Console.ReadLine(), out double dis2);
            Console.WriteLine("Provide your final distance");
            double.TryParse(Console.ReadLine(), out double dis3);
            Console.WriteLine($"Average distance is {Math.Round((dis1 + dis2 + dis3)/3.0,2)}");

            //Part 4
            Console.WriteLine("Provide 2 sides of a Right Triangle");
            double.TryParse(Console.ReadLine(), out double side1);
            double.TryParse(Console.ReadLine(), out double side2);
            Console.WriteLine($"The hypotenuse is {Math.Round(Math.Sqrt(side1 * side1 + (side2 * side2)),2)}");
        }
    }
}