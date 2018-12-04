using System;

namespace _15._Drawing_tools
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine();

			switch (type)
			{
				case "Square":
					int width = int.Parse(Console.ReadLine());
					Square square = new Square(width);
					DrawingTool drawingTool = new DrawingTool(square);
					drawingTool.Figure.Draw();
					break;
				case "Rectangle":
					int width2 = int.Parse(Console.ReadLine());
					int height2 = int.Parse(Console.ReadLine());
					Rectangle rectangle = new Rectangle(width2, height2);
					DrawingTool drawingTool2 = new DrawingTool(rectangle);
					drawingTool2.Figure.Draw();
					break;
			}
		}
	}
}