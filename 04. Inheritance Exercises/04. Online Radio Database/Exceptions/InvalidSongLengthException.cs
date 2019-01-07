using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database.Exceptions
{
	public class InvalidSongLengthException : InvalidSongException
	{
		public InvalidSongLengthException(string message = "Invalid song length.")
			: base(message)
		{

		}
	}
}
