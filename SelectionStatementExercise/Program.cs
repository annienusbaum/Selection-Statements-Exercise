namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 3;

            Console.WriteLine("Pick a number between 1 and 1000");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You are correct!");
            }
            {
                Console.WriteLine("What is your favorite school subject?");

                var subject = Console.ReadLine();

                switch (subject)
                {
                    case "Math":
                        Console.WriteLine("Math is a tough subject!");
                        break;
                    case "English":
                        Console.WriteLine("English is an interesting subject!");
                        break;
                    default:
                        Console.WriteLine($"Oh wow! I haven't taken that subject before.  {subject} sounds fun!");
                            break;

                  


                }
            }
        }
    }
}
