using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BorderControl
{
	class Program
	{
		static void Main(string[] args)
		{
			List<IIdentifiable> all = new List<IIdentifiable>();

			string command;

			while ((command = Console.ReadLine()) != "End")
			{
				string[] tokens = command.Split();

				if (tokens.Length == 3)
				{
					all.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
				}
				else if (tokens.Length == 2)
				{
					all.Add(new Robot(tokens[0], tokens[1]));
				}
			}

			string lastDigits = Console.ReadLine();

			all.Where(c => c.Id.EndsWith(lastDigits))
				.Select(c => c.Id)
				.ToList()
				.ForEach(Console.WriteLine);
		}
	}
}
