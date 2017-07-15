﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string name;
    private int age;

    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

