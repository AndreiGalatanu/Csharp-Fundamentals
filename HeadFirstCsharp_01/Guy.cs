using System;

namespace HeadFirstCsharp_01
{
    class Guy
    {
        public string Name;
        public int Cash;


        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");

        }
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says :" + amount + " isnt't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says :" + "I don't have enough cash to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;

        }
        public void RecieveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("{0} says: {1} isn't an amount I'll take", Name, Cash);
            }
            else
            {
                Cash += amount;
            }
        }



    }
}
