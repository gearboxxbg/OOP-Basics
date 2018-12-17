﻿using System;

namespace _01.Class_Box
{
	class Program
	{
		static void Main(string[] args)
		{
			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			Box box = new Box(length, width, height);

			Console.WriteLine(box.GetSurfaceArea());
			Console.WriteLine(box.GetLateralSurfaceArea());
			Console.WriteLine(box.GetVolume());
		}
	}
}