﻿
using System;

public abstract class Provider : People
{

    private double energyOutput;

    protected Provider(string id, double energyOutput)
        :base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }

  
    public abstract string PrintCheckCommand();
}

