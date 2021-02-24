using System;

namespace HeadFirstCsharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the casino. The odds are 0.75");
            Guy player = new Guy() { Name = "player", Cash = 100 };
            Random random = new Random();
            double odds = 0.75;
            while (true)
            {
                //Have the Guy object print the amount of cash it has
                player.WriteMyInfo();
                //Ask the user how much money to bet.
                Console.WriteLine("How much you want to bet ? : ");
                //Read the line into a string variable called howMuch.
                string howMuch = Console.ReadLine();
                if (player.Cash == 0) return;
                {
                    //Try to parse it into an int variable called amount.
                    if (int.TryParse(howMuch, out int amount))
                    {
                        //If it parses, the player gives the amount to an int variable called pot. 
                        //It gets multiplied by two, because it’s a double-or-nothing bet
                        int pot = amount * 2;

                        //The program picks a random number between 0 and 1.
                        double pick = random.NextDouble();
                        //If the number is greater than odds, the player receives the pot.
                        if (pick > odds)
                        {
                            Console.WriteLine("You win " + pot);
                            player.RecieveCash(pot);
                        }
                        else
                        {
                            //If not, the player loses the amount they bet.
                            Console.WriteLine("Bad luck, you lose");
                            player.GiveCash(amount);

                        }


                    }
                    else { Console.WriteLine("the house allways wins"); }


                }


            }
        }
    }
}
