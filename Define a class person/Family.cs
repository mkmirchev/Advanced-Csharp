﻿using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    class Family
    {
        private readonly HashSet<Person> members;
        public Family()
        {
            this.members = new HashSet<Person>();
        }
        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
        public Person GetOldestMember()
        {
            Person person = this.members.OrderByDescending(x => x.Age).FirstOrDefault();
            return person;

        }
    }
}
