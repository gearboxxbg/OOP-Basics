﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Mankind
{
	public class Student : Human
	{
		private string facultyNumber;

		public Student(string firstName, string lastName, string facultyNumber)
			: base(firstName, lastName)
		{
			this.FacultyNumber = facultyNumber;
		}

		private string FacultyNumber
		{
			get
			{
				return this.facultyNumber;
			}

			set
			{
				string pattern = @"^[a-zA-Z0-9]{5,10}$";

				if (!Regex.IsMatch(value, pattern))
				{
					throw new ArgumentException("Invalid faculty number!");
				}

				this.facultyNumber = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(base.ToString())
				.AppendLine($"Faculty number: {FacultyNumber}");

			return builder.ToString();
		}
	}
}
