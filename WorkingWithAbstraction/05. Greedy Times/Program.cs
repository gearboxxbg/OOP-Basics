﻿using System;

namespace _05._Greedy_Times
{
	class Program
	{
		static void Main(string[] args)
		{
			long capacity = long.Parse(Console.ReadLine());
			string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
			Bag bag = new Bag(capacity);

			for (int i = 0; i < input.Length; i += 2)
			{
				string key = input[i];
				long value = long.Parse(input[i + 1]);

				InsertItem(key, value, bag);
			}

			Console.WriteLine(bag.ToString());
		}

		private static void InsertItem(string key, long value, Bag bag)
		{
			if (key.Length == 3)
			{
				CashItem cash = new CashItem(key, value);
				bag.AddCashItem(cash);
			}
			else if (key.Length >= 4 && key.ToLower().EndsWith("gem"))
			{
				GemItem gem = new GemItem(key, value);
				bag.AddGemItem(gem);
			}
			else if (key.ToLower().Equals("gold"))
			{
				GoldItem gold = new GoldItem(key, value);
				bag.AddGoldItem(gold);
			}
		}
	}
}
