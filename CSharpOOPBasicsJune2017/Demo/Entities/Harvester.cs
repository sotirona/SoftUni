
using System;
using System.Text;

public abstract class Harvester :People
{
  
    private double oreOutput;

    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            this.energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;

        }
    }
    public override string ToString()
    {
        string harvesterType = this.GetType().Name;
        int typeEnd = harvesterType.IndexOf("Harvester");
        harvesterType = harvesterType.Insert(typeEnd, " ");

        return $"Successfully registered {harvesterType} - {this.Id}";
    }

    public virtual string PrintCheckCommand()
    {
        var sb = new StringBuilder();

        string harvesterType = this.GetType().Name;
        int typeEnd = harvesterType.IndexOf("Harvester");
        harvesterType = harvesterType.Insert(typeEnd, " ");

        sb.AppendLine($"{harvesterType} - {this.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().Trim();
    }

   
}

