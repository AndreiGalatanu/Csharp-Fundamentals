using System;

namespace AbilityScoreTester
{
    class Program
    {
        static void Main(string[] args)
        {


            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Startign 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum:");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability scorea : " + calculator.Score);
                Console.WriteLine("Press Q to quit , any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;


            }



        }

        private static double ReadDouble(double divideBy, string prompt)
        {
            Console.WriteLine(prompt + " divided by " + divideBy);
            string line = Console.ReadLine();
            if (double.TryParse(line, out double result))
            {
                Console.WriteLine("divide by :" + result);
                return result;
            }
            else
            {
                Console.WriteLine("default divide" + divideBy);
                return divideBy;
            }
        }

        /// <summary>
        /// Writes a prompt and reads an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            // Write the prompt followed by [default value]:
            Console.WriteLine(prompt + " [" + lastUsedValue + " ] : ");
            // Read the line from the input and use int.TryParse to attempt to parse it
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine(" using value" + value);
                return value;

            }
            else
            {
                Console.WriteLine(" using defoult value" + lastUsedValue);
                return lastUsedValue;
            }
            // If it can be parsed, write " using value" + value to the console
            // Otherwise write " using default value" + lastUsedValue to the console
        }

    }

    class AbilityScoreCalculator
    {

        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Divide the roll result by the DivideBy field
            double divided = RollResult / DivideBy;

            // Add AddAmount to the result of that division
            int added = AddAmount += (int)divided;

            // If the result is too small, use Minimum
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }




    }

}
