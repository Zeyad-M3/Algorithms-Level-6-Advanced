//using System;
//using System.Collections.Generic;

//class coinChange
//{
//    static void Main(   ) // Note: cointype parameter is not used
//    {
//        int[] coins = { 50, 20, 10, 5, 1 };
//        int amount = 25;
//        int count = 0;
//        List<int> usedCoins = new List<int>(); // Use a list to store used coins

//        foreach (int coin in coins)
//        {
//            if (amount >= coin)
//            {
//                int num = amount / coin;
//                count += num;
//                for (int i = 0; i < num; i++)
//                {
//                    usedCoins.Add(coin); // Add the coin value for each time it's used
//                }
//                amount -= num * coin;
//            }
//        }
//        Console.WriteLine($"the amount of the coin we need {count}");
//        foreach (int coinChange in usedCoins)
//        {
//            Console.WriteLine($"the coin we use {coinChange}");
//        }
//    }
//}
