using System;

namespace HowMuchMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HowMuchMoney.Program.Main()\n");

            Bank MyBank = new Bank();

            int numCoins = MyBank.CountMyCoins();
            Console.WriteLine($"WOW!  I have {numCoins} coins in my bank!/n");

            string[] AllMyCoins = MyBank.GetCoins(numCoins);
            //MyBank.GetCoins(numCoins);

            int howMuch = MyBank.HowMuch(AllMyCoins);
            Console.WriteLine($"\nI have {howMuch} cents in my bank!  Woohoo!!!");
        }
    }
}
