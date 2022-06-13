using System;
using AssessmentTask;


namespace ConsoleDiceRoll
{
    internal class Program
    {
        private static ClGame clGame;
        static void Main(string[] args)
        {
            clGame = new ClGame();
            RollDice();
            PrintAverage();

        }

        public static void RollDice()
        {
            ClGame tempClGame = new ClGame();
            var numberOfDiceToRoll = NumDiceToRoll();

            for (int i = 0; i < numberOfDiceToRoll; i++)
            {
                tempClGame.AddDie(6);
            }

            tempClGame.RollAllDice();
            clGame.Results.AddRange(tempClGame.Results);
            for (int i = 0; i < tempClGame.Results.Count; i++)
            {
                Console.WriteLine($"DIE {i + 1} ROLLED {tempClGame.Results[i]}");
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("Would you like to roll again? type 'yes' or 'no'");
            var input = Console.ReadLine().ToLower();
            if (input.Equals("yes"))
            {
                RollDice();
            }
            
        }

        public static void PrintAverage()
            {
            for (int i = 0; i < clGame.Results.Count; i++)
            {
                Console.WriteLine($"DIE {i + 1} ROLLED {clGame.Results[i]}");
                Console.WriteLine("-------------------");
            }

            Console.WriteLine($"The average of the die was {clGame.GetAverage()}");
                Console.WriteLine($"The total of the die was {clGame.GetTotal()}");
        }


        public static int NumDiceToRoll()
        {
            Console.WriteLine("How many dice do you want to roll?");
            var num = Int32.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Dice out of range, try again");
                return NumDiceToRoll();
            }

            return num;

        }

    }
}
