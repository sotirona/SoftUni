using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private readonly List<Harvester> harvesters;
    private readonly List<Provider> providers;

    private double SummedOreOutput { get; set; }

    private double SummedEnergyOutput { get; set; }

    private string ModeType { get; set; }

    private double TotalMinedOre { get; set; }

    private double TotalStoredEnergy { get; set; }

    public DraftManager()
    {
        this.TotalStoredEnergy = 0;
        this.TotalMinedOre = 0;
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.SummedEnergyOutput = 0;
        this.SummedOreOutput = 0;
        this.ModeType = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var currentHarvester = HarvesterFactory.GetHarvester(arguments);
            harvesters.Add(currentHarvester);
            return currentHarvester.ToString();
        }

        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var currentProvider = ProviderFactory.GetProvider(arguments);
            providers.Add(currentProvider);
            return currentProvider.ToString();
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string Day()
    {
        var requiredEnergy = 0.0;
        this.SummedOreOutput = 0;
        this.SummedEnergyOutput = providers.Sum(x => x.EnergyOutput);
        this.TotalStoredEnergy += this.SummedEnergyOutput;

        if (this.ModeType == "Full")
        {
            requiredEnergy = harvesters.Sum(x => x.EnergyRequirement);
            
            if (requiredEnergy <= this.TotalStoredEnergy)
            {
                this.SummedOreOutput = harvesters.Sum(x => x.OreOutput);
                this.TotalStoredEnergy -= requiredEnergy;
                this.TotalMinedOre += this.SummedOreOutput;
            }
        }

        if (this.ModeType == "Half")
        {
            requiredEnergy = harvesters.Sum(x => x.EnergyRequirement) * 0.6;
            
            if (requiredEnergy <= this.SummedEnergyOutput)
            {
                this.SummedOreOutput = harvesters.Sum(x => x.OreOutput) * 0.5;
                this.TotalStoredEnergy -= requiredEnergy;
                this.TotalMinedOre += this.SummedOreOutput;
            }
        }
        
        var sb = new StringBuilder();

        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {this.SummedEnergyOutput}");
        sb.AppendLine($"Plumbus Ore Mined: {this.SummedOreOutput}");
        
        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.ModeType = arguments[0];
        return $"Successfully changed working mode to {this.ModeType} Mode";
    }

    public string Check(List<string> arguments)
    {
        var currentId = arguments[0];

        if (harvesters.Any(x => x.Id == currentId))
        {
            var currentHarvester = harvesters.FirstOrDefault(x => x.Id == currentId);

            return currentHarvester.PrintCheckCommand();
        }

        if (providers.Any(x => x.Id == currentId))
        {
            var currentProvider = providers.FirstOrDefault(x => x.Id == currentId);
            return currentProvider.PrintCheckCommand();
        }

        return $"No element found with id - {currentId}";
        
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.TotalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.TotalMinedOre}");

        return sb.ToString().Trim();
    }

}

