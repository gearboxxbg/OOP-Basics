using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Hospital
{
	public class Patient
	{
		public Patient(string name)
		{
			Name = name;
		}

		public string Name { get; private set; }
	}
}