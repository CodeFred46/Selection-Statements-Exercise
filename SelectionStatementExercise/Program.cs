using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Number Guessing Game
            

            var r = new Random();
            var favNumber = r.Next(1, 1001);
            
           
            Console.WriteLine("Guess my favorite number from 1-1000?");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine($"Number {userInput} too low");
            }
            if(userInput > favNumber)
            {
                Console.WriteLine($"Number {userInput} too high");
            }
            if(userInput == favNumber)
            {
                Console.WriteLine("You Guessed my number!");
            }

            

        }
    }
}
