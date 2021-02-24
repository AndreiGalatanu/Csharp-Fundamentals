using System;

namespace HeadFirstCsharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };



            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.WriteLine("Enter the amount");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                {
                    if (int.TryParse(howMuch, out int amount))
                    {
                        Console.WriteLine("Who shoudl give the cash: ");
                        string whichGuy = Console.ReadLine();
                        if (whichGuy == "Joe")
                        {
                            int cashGiven = joe.GiveCash(amount);
                            bob.RecieveCash(cashGiven);
                        }
                        else if (whichGuy == "Bob")
                        {
                            int cashGiven = bob.GiveCash(amount);
                            joe.RecieveCash(cashGiven);

                        }
                        else
                        {
                            Console.WriteLine("Plese enter Joe or Bob");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an amount ( or blank line to exit)");
                    }

                }
            }
        }
    }
}
