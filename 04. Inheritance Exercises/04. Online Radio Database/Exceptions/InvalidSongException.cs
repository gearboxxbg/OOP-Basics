﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database.Exceptions
{
	public class InvalidSongException : Exception
	{
		public InvalidSongException(string message = "Invalid song.")
			: base(message)
		{

		}
	}
}
