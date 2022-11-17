namespace IterationStatementExercisePartThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for which you wish to see factorialized (presuming that's a real term).");

            var userInput = Console.ReadLine();
            int theNumberInQuestion = int.Parse(userInput);

            for (var i = theNumberInQuestion - 1; i > 0; i--)
            {
                theNumberInQuestion = i * theNumberInQuestion;
            }

            Console.WriteLine(string.Format("The factorial of {0} is {1}.", userInput, theNumberInQuestion));
        }
    }
}