using System;

namespace CardPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");


            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in PickRandom.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }

            }
            else
            {
                Console.WriteLine(" Please pick a number");

            }
        }
    }


}
