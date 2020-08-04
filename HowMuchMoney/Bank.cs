using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HowMuchMoney
{
    public class Bank
    {
        static string[] coins = { "penny", "nickel", "dime", "quarter" };
        Random RandomNumber;

        public Bank()
        {
            RandomNumber = new Random();
        }

        public Bank( int RandomSeed )
        {
            RandomNumber = new Random(RandomSeed);
        }

        public int CountMyCoins()
        {
            return RandomNumber.Next(10, 1000);
        }

        public string[] GetCoins( int howMany)
        {
            string[] MyCoins = new string[howMany];

            for (int i = 0; i < howMany; i++)
            {
                MyCoins[i] = coins[RandomNumber.Next(0, 4)];
                //Console.Write(MyCoins[i] + ' ');
            }

            return MyCoins;
        }

        public int HowMuch( string[] AllTheCoins)
        {
            int total = 0;

            //TODO: count them!
            for (int i = 0; i < AllTheCoins.Length ; i++)
            {
                if (AllTheCoins[i] == "penny") total += 1;
                else if (AllTheCoins[i] == "nickel") total += 5;
                else if (AllTheCoins[i] == "dime") total += 10;
                else total += 25;
            }

            return total;
        }
    }
}
