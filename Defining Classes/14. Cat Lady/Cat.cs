using System;
using System.Collections.Generic;
using System.Text;

namespace _14._Cat_Lady
{
	public class Cat
	{
		private string name;

		public Cat(string name)
		{
			this.name = name;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
		}
	}
}