using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string resp = "y";

        // Loop 1
        do
        {         
            Console.Write("Magic Number? ");
            string num = Console.ReadLine();
            int Answer = int.Parse(num);
            
            int x;

            do
            {
                Console.Write("Hello! What is the magic number (Choose between 0-100)? ");
                string value = Console.ReadLine();
                x = int.Parse(value);

                if (Answer == x)
                {
                    Console.Write("Congrats! You guessed the magic number!");
                }
                else if (Answer > x)
                {
                    Console.WriteLine("Too low! Guess again.");
                }
                else
                {
                    Console.WriteLine("Too high! Guess again.");
                }

            } while (x != Answer);

            Console.WriteLine("Play again? (y/n); ");
            resp = Console.ReadLine();

        } while (resp == "y");

    }
}
