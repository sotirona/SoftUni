
using System;
using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
    : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += base.OreOutput * 2;
        this.EnergyRequirement += this.EnergyRequirement;
    }

    
}

