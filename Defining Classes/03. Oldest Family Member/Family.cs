﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
	class Family
	{
		private List<Person> members;

		public Family()
		{
			this.members = new List<Person>();
		}

		public void AddMember(Person member)
		{
			this.members.Add(member);
		}

		public Person GetOldestMember()
		{
			return this.members
				.OrderByDescending(p => p.Age)
				.First();
		}
	}
}