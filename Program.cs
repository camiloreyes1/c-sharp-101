using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {

      int gold = 10;
      int silver = 5;

      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please input the amount of money you have");

      string money = Console.ReadLine();

      double moneyExact = Convert.ToDouble(money);

      double goldCoins = Math.Floor(moneyExact / gold);
      double change = goldCoins % gold;

      double totalGoldCoins = goldCoins + change;

      Console.WriteLine(money + " is equal to ..." + totalGoldCoins);
      
    }
  }
}
