using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please input the amount of money you have");

      string money = Console.ReadLine();

      double moneyExact = Convert.ToDouble(money);

      Console.WriteLine(money);
      
    }
  }
}
