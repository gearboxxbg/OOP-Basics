using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Shopping_Spree
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
			List<Person> persons = new List<Person>();
			List<Product> products = new List<Product>();

			foreach (string pair in input)
			{
				string[] tokens = pair.Split('=');

				try
				{
					persons.Add(new Person(tokens[0], decimal.Parse(tokens[1])));
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
					return;
				}
			}

			input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

			foreach (string pair in input)
			{
				string[] tokens = pair.Split('=');

				try
				{
					products.Add(new Product(tokens[0], decimal.Parse(tokens[1])));
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
					return;
				}
			}

			string command;

			while ((command = Console.ReadLine()) != "END")
			{
				string[] tokens = command.Split();

				string personName = tokens[0];
				string productName = tokens[1];

				Person person = persons.Single(p => p.Name == personName);
				Product product = products.Single(p => p.Name == productName);

				if (!person.BuyProduct(product))
				{
					Console.WriteLine($"{person.Name} can't afford {product.Name}");
				}
				else
				{
					Console.WriteLine($"{person.Name} bought {product.Name}");
				}
			}

			foreach (Person person in persons)
			{
				string productsBought = person.Products.Count == 0 ? "Nothing bought" : String.Join(", ", person.Products.Select(p => p.Name));

				Console.WriteLine($"{person.Name} - {productsBought}");
			}
		}
	}
}