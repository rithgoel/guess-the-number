using System;
using static System.Math;

namespace project1summer
{
    class Program
    {
        static void Main(string[] args)
        {



            Random rnd = new Random();


            while (true)
            {
                int randomNumber = rnd.Next(1, 100);
                int counter = 1; //this allows the loop to stay true if the guess is wrong
                bool retry = true;
                while (true)
                {

                    Console.WriteLine("Enter guess: ");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low; try again.");
                        ++counter;
                        continue;

                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Too High, try again.");
                        ++counter;
                        continue;

                    }
                    else
                    {
                        Console.WriteLine("Good job. You guess the number");
                        Console.WriteLine("Would you like to retey? y/n");
                        string entry = Console.ReadLine();
                        if (entry != "y")
                        {
                            retry = false;
                        }
                        break;


                    }

                }
                if (!retry) break;
            }
        }
    }
}
