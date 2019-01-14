using System;

namespace _03._Ferrari
{
	class Program
	{
		static void Main(string[] args)
		{
			string driver = Console.ReadLine();
			Ferrari ferrari = new Ferrari(driver);
			Console.WriteLine(ferrari);
		}
	}
}
