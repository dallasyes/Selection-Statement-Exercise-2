namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Math is cool because it's all about solving problems!");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is cool because it's all about solving problems");
                    break;
                case "History":
                    Console.WriteLine("History is cool because it's all about solving problems");
                    break; 
                case "Social Studies":
                    Console.WriteLine("Social Studies is cool because it's cool");
                    break;
                case "Gym":
                    Console.WriteLine("Gym is cool because it's all about solving problems");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}