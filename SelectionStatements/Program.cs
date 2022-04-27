using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Can you guess my favorite number?");


            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());


            if (favNumber > userInput)
            {
                Console.WriteLine("too low!");
                Console.WriteLine("it was! " + favNumber);
                   
            }
            else if (favNumber < userInput)
            {
                Console.WriteLine("Too high!!");
                Console.WriteLine("it was! " + favNumber);
            }
            else
            {
                Console.WriteLine("you got it!");
                Console.WriteLine("it was! " + favNumber);
            }


            Console.WriteLine("Next Question what is your favorite subject in school? ");
            string input = Console.ReadLine();
            string choice = input.ToLower();


            switch (choice)
            {
                case "math":
                    Console.WriteLine("Math is a great one to be good at!");
                    break;
                case "science":
                    Console.WriteLine("Your are a smart preson for your favorite to be science");
                    break;
                case "pe":
                   Console.WriteLine("you must be an ative person to love pe");
                    break;
                case "english":
                    Console.WriteLine("Your are a smart preson for your favorite to be english");
                    break;
                case "art":
                    Console.WriteLine("Your are a very creative person to love art!");
                    break;
                default:
                    Console.WriteLine("Wow I dont take that subject!");
                    break;



            }










        }
    }
}
