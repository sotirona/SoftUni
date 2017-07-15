﻿
using System;

public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }
    
    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        set { this.earthAffinity = value; }
    }

    public override int GetMonumentPower()
    {
        return this.earthAffinity;
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
    }

}

