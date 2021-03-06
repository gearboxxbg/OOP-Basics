﻿using _04._Online_Radio_Database.Exceptions;
using System;

namespace _04._Online_Radio_Database
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			Playlist playlist = new Playlist();

			for (int i = 0; i < count; i++)
			{
				string[] input = Console.ReadLine().Split(';');

				try
				{
					Song song = new Song(input);
					Console.WriteLine(playlist.AddSong(song));
				}
				catch (InvalidSongException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			Console.WriteLine(playlist);
		}
	}
}
