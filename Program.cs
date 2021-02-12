using System;
using Games;

namespace Project3
{
	class Program
	{
		static void Main()
		{
			Coin[] coins = new Coin[5];
			coins[0] = new Coin();
			coins[1] = new Coin();
			coins[2] = new Coin();
			coins[3] = new Coin();
			coins[4] = new Coin();


			FlipAndDescribe(coins);
			Console.Read();
		}

		public static void FlipAndDescribe(Coin[] coins)
        {
			foreach (Coin coin in coins)
            {
				Console.WriteLine(coin.Result());
            }
			Console.WriteLine();
        }
	}
}
