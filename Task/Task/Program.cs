namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task list:");
            Console.WriteLine("1. Time calculator");
            Console.WriteLine("2. Determination of age category");
            Console.WriteLine("3. Calculate the average score");
            Console.WriteLine("4. Game of \"Find the number\"");
            Console.Write("To select one of the tasks, enter its number: ");
            short taskNumber = Convert.ToInt16(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:
                    FirstTask.Task();
                    break;
                case 2:
                    SecondTask.Task();
                    break;
                case 3:
                    ThirdTask.Task();
                    break;
                case 4:
                    FourthTask.Task();
                    break;
                default:
                    Console.WriteLine("Task Not Found!");
                    break;
            }
        }
    }
}