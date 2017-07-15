
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, List<Bender>> benders;
    private Dictionary<string, List<Monument>> monuments;
    private Queue<string> figthters;
    private List<double> powers;

    public NationsBuilder()
    {
        this.benders = new Dictionary<string, List<Bender>>();
        this.monuments = new Dictionary<string, List<Monument>>();
        this.figthters = new Queue<string>();
        this.powers = new List<double>();

        this.benders.Add("Earth", new List<Bender>());
        this.benders.Add("Fire", new List<Bender>());
        this.benders.Add("Water", new List<Bender>());
        this.benders.Add("Air", new List<Bender>());

        this.monuments.Add("Earth", new List<Monument>());
        this.monuments.Add("Fire", new List<Monument>());
        this.monuments.Add("Water", new List<Monument>());
        this.monuments.Add("Air", new List<Monument>());

    }

    public void AssignBender(List<string> benderArgs)
    {
        var bender = BendersFactory.GetBender(benderArgs[1], benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
        this.benders[benderArgs[1]].Add(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monument = MonumentsFactory.GetMonument(monumentArgs[1], monumentArgs[2], int.Parse(monumentArgs[3]));
        this.monuments[monumentArgs[1]].Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{nationsType} Nation");

        foreach (var kvp in benders)
        {
            if (kvp.Key == nationsType)
            {
                if (kvp.Value.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in kvp.Value)
                    {
                        sb.AppendLine($"###{bender}");
                    }
                }
            }
        }

        foreach (var kvp in monuments)
        {
            if (kvp.Key == nationsType)
            {
                if (kvp.Value.Count == 0)
                {
                    sb.AppendLine("Monuments: None");
                }
                else
                {
                    sb.AppendLine("Monuments:");
                    foreach (var monument in kvp.Value)
                    {
                        sb.AppendLine($"###{monument}");
                    }
                }
            }
        }

        return sb.ToString().Trim();
    }
    public void IssueWar(string nationstype)
    {
        figthters.Enqueue(nationstype);

        int airMonumentsPower = monuments.Where(x => x.Key == "Air").Sum(x => x.Value.Sum(y => y.GetMonumentPower()));
        int fireMonumentsPower = monuments.Where(x => x.Key == "Fire").Sum(x => x.Value.Sum(y => y.GetMonumentPower()));
        int earthMonumentsPower = monuments.Where(x => x.Key == "Earth").Sum(x => x.Value.Sum(y => y.GetMonumentPower()));
        int waterMonumentsPower = monuments.Where(x => x.Key == "Water").Sum(x => x.Value.Sum(y => y.GetMonumentPower()));

        double earthBendersPower = benders.Where(x => x.Key == "Earth").Sum(x => x.Value.Sum(y => y.GetPower()));
        double fireBendersPower = benders.Where(x => x.Key == "Fire").Sum(x => x.Value.Sum(y => y.GetPower()));
        double waterBendersPower = benders.Where(x => x.Key == "Water").Sum(x => x.Value.Sum(y => y.GetPower()));
        double airBendersPower = benders.Where(x => x.Key == "Air").Sum(x => x.Value.Sum(y => y.GetPower()));

        double totalAirPower = airBendersPower;
        double totalFirePower = fireBendersPower;
        double totalEarthPower = earthBendersPower;
        double totalWaterPower = waterBendersPower;

        if (airMonumentsPower!=0)
        {
            totalAirPower += (airBendersPower / 100) * airMonumentsPower;
        }

        if (fireMonumentsPower!=0)
        {
            totalFirePower += (fireBendersPower / 100) * fireMonumentsPower;
        }
        if (earthMonumentsPower!=0)
        {
            totalEarthPower += (earthBendersPower / 100) * earthMonumentsPower;
        }
        if (waterBendersPower!=0)
        {
            totalWaterPower += (waterBendersPower / 100) * waterMonumentsPower;
        }

        var nations = new Dictionary<string, double>();

        nations.Add("Air", totalAirPower);
        nations.Add("Fire", totalFirePower);
        nations.Add("Earth", totalEarthPower);
        nations.Add("Water", totalWaterPower);

        var winner = nations.OrderByDescending(x => x.Value).FirstOrDefault();

        RemoveBenders(winner.Key);

        RemoveMonuments(winner.Key);
        
    }

    private void RemoveMonuments(string key)
    {
        switch (key)
        {
            case "Air":

                foreach (var kvp in monuments.Where(x => x.Key != "Air"))
                {
                    kvp.Value.Clear();
                }
                break;

            case "Fire":

                foreach (var kvp in monuments.Where(x => x.Key != "Fire"))
                {
                    kvp.Value.Clear();
                }
                break;

            case "Water":

                foreach (var kvp in monuments.Where(x => x.Key != "Water"))
                {
                    kvp.Value.Clear();
                }
                break;

            case "Earth":

                foreach (var kvp in monuments.Where(x => x.Key != "Earth"))
                {
                    kvp.Value.Clear();
                }
                break;
        }
    }

    private void RemoveBenders(string key)
    {
        switch (key)
        {
            case "Air":

                foreach (var kvp in benders.Where(x => x.Key != "Air"))
                {
                    kvp.Value.Clear();
                }
                break;

            case "Fire":

                foreach (var kvp in benders.Where(x => x.Key != "Fire"))
                {
                    kvp.Value.Clear();
                }
                break;

            case "Water":

                foreach (var kvp in benders.Where(x => x.Key != "Water"))
                {
                    kvp.Value.Clear();
                }
                break;

            case "Earth":

                foreach (var kvp in benders.Where(x => x.Key != "Earth"))
                {
                    kvp.Value.Clear();
                }
                break;
        }
    }

    public string GetWarsRecord()
    {
        int n = 1;
        var sb = new StringBuilder();

        int count = figthters.Count;

        for (int i = 0; i < count; i++)
        {
            sb.AppendLine($"War {n} issued by {figthters.Dequeue()}");
            n++;
        }

        return sb.ToString().Trim();
    }

}

