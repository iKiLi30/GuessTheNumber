using System;

namespace GuessTheNumber
{
    internal class Program
    {
        int secretNumber = 0;
        int guess = 0;
      

        static void Main(string[] args)
        {
            Console.WriteLine("Hello player, today you will guess the secret number between 1 - 10");
            Console.WriteLine("Enter your number ");
            Program program = new Program();
            
            program.Guess();
        }
        void Guess()
        {   
            Random random = new Random();
            secretNumber = random.Next(1, 10);
            int? guess = Convert.ToInt32(Console.ReadLine());
            if (guess > secretNumber)
            {
                Console.WriteLine("My number lower, try againe");
                Guess();
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("My number higher, try againe");
                Guess();
            }
            else
            {
                Win();
            }
        }
        void Win()
        {
            Console.WriteLine("You WIN");
        }
    }
}
