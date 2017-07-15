﻿
using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people;

    public Family()
    {
        this.People = new List<Person>();
    }

    public List<Person> People { get; set; }

    public void AddMember(Person member)
    {
        this.People.Add(member);
    }
    
    public Person GetOldestMember()
    {
        return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}

